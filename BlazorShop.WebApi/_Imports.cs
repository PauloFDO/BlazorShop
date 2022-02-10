﻿global using FluentValidation.AspNetCore;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.IdentityModel.Tokens;
global using BlazorShop.Application;
global using BlazorShop.Application.Common.Interfaces;
global using BlazorShop.Infrastructure;
global using BlazorShop.Infrastructure.Persistence;
global using BlazorShop.WebApi.Filters;
global using Serilog;
global using System.Text;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Filters;
global using BlazorShop.Application.Commands.UserCommand;
global using BlazorShop.Application.Queries.UserQuery;
global using MediatR;
global using Stripe;
global using Microsoft.AspNetCore.Authorization;
global using BlazorShop.Application.Commands.OrderCommand;
global using BlazorShop.Application.Queries.OrderQuery;
global using BlazorShop.Application.Commands.AccountCommand;
global using BlazorShop.Application.Queries.ClotheQuery;
global using BlazorShop.Application.Commands.ClotheCommand;
global using BlazorShop.Domain.Entities.Identity;
global using BlazorShop.Infrastructure.Utils;
global using Microsoft.AspNetCore.Identity;
global using BlazorShop.Application.Common.Models;
global using BlazorShop.Application.Commands.RoleCommand;
global using BlazorShop.Application.Queries.RoleQuery;
global using BlazorShop.Application.Commands.CartCommand;
global using BlazorShop.Application.Queries.CartQuery;
global using BlazorShop.Application.Responses;
global using Stripe.Checkout;
global using System.Net.Http.Headers;
global using BlazorShop.UnitOfWork;
global using BlazorShop.UnitOfWork.Interfaces;
global using BlazorShop.Application.Commands.MusicCommand;
global using BlazorShop.Application.Queries.MusicQuery;
global using BlazorShop.Application.Commands.SubscriberCommand;
global using BlazorShop.Application.Commands.InvoiceCommand;
global using BlazorShop.Application.Commands.ReceiptCommand;
global using BlazorShop.Application.Queries.SubscriberQuery;
global using BlazorShop.Application.Commands.SubscriptionCommand;
global using BlazorShop.Application.Queries.SubscriptionQuery;
global using BlazorShop.Application.Queries.InvoiceQuery;
global using BlazorShop.Application.Queries.ReceiptQuery;
global using System.Text.Json;
global using BlazorShop.Application.Common.Exceptions;
global using BlazorShop.WebApi.Controllers;
global using BlazorShop.Application.Utils;
global using BlazorShop.Application.Commands.TodoItemCommand;
global using BlazorShop.Application.Commands.TodoListCommand;
global using BlazorShop.Application.Queries.TodoItemQuery;
global using BlazorShop.Application.Queries.TodoListQuery;
