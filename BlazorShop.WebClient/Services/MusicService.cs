﻿// <copyright file="MusicService.cs" company="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

using MudBlazor;

namespace BlazorShop.WebClient.Services
{
    /// <summary>
    /// An implementation of <see cref="IMusicService"/>.
    /// </summary>
    public class MusicService : IMusicService
    {
        private readonly HttpClient _httpClient;
        private readonly ISnackbar _snackBar;
        private readonly NavigationManager _navMagager;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _localStorage;
        private readonly JsonSerializerOptions _options;

        public MusicService(HttpClient httpClient, ISnackbar snackBar, NavigationManager navMagager, AuthenticationStateProvider authStateProvider, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _snackBar = snackBar;
            _navMagager = navMagager;
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
        }

        /// <inheritdoc/>
        public async Task<List<MusicResponse>> GetMusics()
        {
            var response = await _httpClient.GetAsync("Musics/musics");

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                await _localStorage.RemoveItemAsync("authToken");
                //((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(string.Empty);

                ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
                _navMagager.NavigateTo("/login");
                return null;
            }

            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<Result<MusicResponse>>(
                responseResult, _options
            );

            if (response.IsSuccessStatusCode == false)
            {
                _snackBar.Add(result.Error, Severity.Error);
            }

            return !response.IsSuccessStatusCode
                ? null
                : result.Items;
        }

        /// <inheritdoc/>
        public async Task<MusicResponse> GetMusic(int id)
        {
            var response = await _httpClient.GetAsync($"Musics/music/{id}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<Result<MusicResponse>>(
                responseResult, _options
            );

            if (response.IsSuccessStatusCode == false)
            {
                _snackBar.Add(result.Error, Severity.Error);
            }

            return !response.IsSuccessStatusCode
                ? null
                : result.Item;
        }

        /// <inheritdoc/>
        public async Task<RequestResponse> AddMusic(MusicResponse music)
        {
            var response = await _httpClient.PostAsJsonAsync("Musics/music", music);
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<RequestResponse>(
                responseResult, _options
            );

            if (response.IsSuccessStatusCode == false)
            {
                _snackBar.Add(result.Error, Severity.Error);
            }
            else
            {
                _snackBar.Add("The Music was added.", Severity.Success);
            }

            return result;
        }

        /// <inheritdoc/>
        public async Task<RequestResponse> UpdateMusic(MusicResponse music)
        {
            var response = await _httpClient.PutAsJsonAsync("Musics/music", music);
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<RequestResponse>(
                responseResult, _options
            );

            if (response.IsSuccessStatusCode == false)
            {
                _snackBar.Add(result.Error, Severity.Error);
            }
            else
            {
                _snackBar.Add("The Music was updated.", Severity.Success);
            }

            return result;
        }

        /// <inheritdoc/>
        public async Task<RequestResponse> DeleteMusic(int id)
        {
            var response = await _httpClient.DeleteAsync($"Musics/music/{id}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<RequestResponse>(
                responseResult, _options
            );

            if (response.IsSuccessStatusCode == false)
            {
                _snackBar.Add(result.Error, Severity.Error);
            }
            else
            {
                _snackBar.Add("The Music was deleted.", Severity.Success);
            }

            return result;
        }
    }
}
