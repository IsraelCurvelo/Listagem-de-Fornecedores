﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prodam.Data;

namespace Prodam.Migrations
{
    [DbContext(typeof(DALContext))]
    partial class DALContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Prodam.Models.Dominio.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnpj");

                    b.Property<string>("Nome");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Prodam.Models.Dominio.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CpfCnpj");

                    b.Property<int>("EmpresaId");

                    b.Property<DateTime>("MomentoCadastro");

                    b.Property<string>("Nome");

                    b.Property<bool>("TipoPessoa");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Prodam.Models.Dominio.PessoaFisica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("FornecedorId");

                    b.Property<string>("Rg");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId")
                        .IsUnique();

                    b.ToTable("PessoaFisica");
                });

            modelBuilder.Entity("Prodam.Models.Dominio.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FornecedorId");

                    b.Property<int>("Numero");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("Prodam.Models.Dominio.Fornecedor", b =>
                {
                    b.HasOne("Prodam.Models.Dominio.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prodam.Models.Dominio.PessoaFisica", b =>
                {
                    b.HasOne("Prodam.Models.Dominio.Fornecedor")
                        .WithOne("DadosPessoaFisica")
                        .HasForeignKey("Prodam.Models.Dominio.PessoaFisica", "FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prodam.Models.Dominio.Telefone", b =>
                {
                    b.HasOne("Prodam.Models.Dominio.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");
                });
#pragma warning restore 612, 618
        }
    }
}
