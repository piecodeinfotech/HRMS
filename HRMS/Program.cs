using AutoMapper;
using HRMS.Helpers;
using HRMS.Logic.Database;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Logic.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
    var Key = Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]);
    o.SaveToken = true;
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        ValidAudience = builder.Configuration["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Key)
    };
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "HRMS API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddScoped<IBloodGroup, BloodGroupService>();
builder.Services.AddScoped<IBranches, BranchService>();
builder.Services.AddScoped<ICast,CastService>();
builder.Services.AddScoped<ICompanies, CompaniesService>();
builder.Services.AddScoped<ICountries, CountriesService>();
builder.Services.AddScoped<IDepartment, DepartmentService>();
builder.Services.AddScoped<IDesignation, DesignationService>();
builder.Services.AddScoped<IDistricts,DistrictsService>();
builder.Services.AddScoped<IEmployeeCategory, EmployeeCategoryService>();
builder.Services.AddScoped<IEmployeeType, EmployeeTypeService>();
builder.Services.AddScoped<IHigherAuthority, HigherAuthorityService>();
builder.Services.AddScoped<IHigherAuthorityBranch, HigherAuthorityBranchService>();
builder.Services.AddScoped<IHigherAuthorityName, HigherAuthorityNameService>();
builder.Services.AddScoped<IProductions, ProductionsService>();
builder.Services.AddScoped<IRegionZone,RegionZoneService>();
builder.Services.AddScoped<IRegions, RegionsService>();
builder.Services.AddScoped<IRelationship, RelationshipService>();
builder.Services.AddScoped<IProfessionalInformation, ProfessionalInformationService>();
builder.Services.AddScoped< IStates, StatesService>();
builder.Services.AddScoped<IThirdParty, ThirdPartyService>();
builder.Services.AddScoped<IThirdPartyType, ThirdPartyTypeService>();
builder.Services.AddScoped<IUserType, UserTypeService>();
builder.Services.AddScoped<IWorkingStatus, WorkingStatusService>();
builder.Services.AddScoped<ICorresspondanceContInfo, CorresspondanceContInfoService>();
builder.Services.AddScoped<IEduQualifiAttach, EduQualifiAttachService>();

builder.Services.AddScoped<IEmployeeMaster, EmployeeMastersService>();
































builder.Services.AddDbContext<HRMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectDb")));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
