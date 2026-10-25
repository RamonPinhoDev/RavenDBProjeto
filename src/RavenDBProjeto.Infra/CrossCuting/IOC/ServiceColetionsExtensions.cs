



using RavenDBProjeto.Aplication;
using RavenDBProjeto.Aplication.Interfaces;
using RavenDBProjeto.Aplication.Mappers;
using RavenDBProjeto.Domain.Core.Interfaces.Repositories;
using RavenDBProjeto.Domain.Core.Interfaces.Services;
using RavenDBProjeto.Domain.Service;
using RavenDBProjeto.Infra.Data;
using System.Security.Cryptography.X509Certificates;

namespace RavenDBProjeto.Infra.CrossCuting.IOC
{
    public static class ServiceColetionsExtensions
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {


            services.AddScoped<IClienteService, ClienteService>();

            services.AddScoped<IClienteRepository, ClienteRepository>();


            services.AddScoped<IClienteAplication, ClienteAplication>();

            services.AddAutoMapper(C=> C.AddProfile<DtoToModelMapping>());

            services.AddSingleton<IDocumentStore>(
                ctx => {

                    string certificatePath = @"D:\\Udemy\\ProjetosC#\\RavenDB\\RavenDB-7.2.7-windows-x64\\ramondev.Cluster.Settings 2026-10-23 01-52\\admin.client.certificate.ramondev.pfx";
                    var x509Certificate = new X509Certificate2(certificatePath);

                    var loja = new DocumentStore { 
                        Urls = new string [] { "https://a.ramondev.development.run/" },
                        Database = "RavenDBProjeto", Certificate = x509Certificate
                    };
                    

                    loja.Initialize();


                    return loja;

                });



            return services;
        }
    }
}
