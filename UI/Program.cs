using Business.Abstract;
using Business.Concrete;
using Data.Abstract;
using Data.Concrete;
using Data.EF;
using Data.Repository;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

 builder.Services.AddControllersWithViews();

 builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/";
});

 builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

 builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();

 
// AboutUs
builder.Services.AddScoped<IAboutUsService, AboutUsManager>();
builder.Services.AddScoped<IAboutUsDal, EfAboutUsDal>();

// Contact
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();

// Fleet
builder.Services.AddScoped<IFleetService, FleetManager>();
builder.Services.AddScoped<IFleetDal, EfFleetDal>();

// Gallery
builder.Services.AddScoped<IGalleryService, GalleryManager>();
builder.Services.AddScoped<IGalleryDal, EfGalleryDal>();

// Service
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();

// Expertice
builder.Services.AddScoped<IExperticeService, ExperticeManager>();
builder.Services.AddScoped<IExperticeDal, EfExperticeDal>();

// Crew
builder.Services.AddScoped<ICrewService, CrewManager>();
builder.Services.AddScoped<ICrewDal, EfCrewDal>();

  
 var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

 app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
