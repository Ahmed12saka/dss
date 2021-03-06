using dss.Repository;
using dss.Services;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStr")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IStudent, StudentRepository>();
builder.Services.AddTransient<ISchool, SchoolRepository>();
builder.Services.AddTransient<ICourse, CourseRepository>();
builder.Services.AddTransient<IEnrollment, EnrollmentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
