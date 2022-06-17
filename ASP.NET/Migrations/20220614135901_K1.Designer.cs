﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace ASP.NET.Migrations
{
    [DbContext(typeof(AgencijaContext))]
    [Migration("20220614135901_K1")]
    partial class K1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Models.AgencijaOpsta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("gmail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("kontakt")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("lokacija")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("oNama")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("text1")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("text2")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("text3")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("AgencijaOpsta");
                });

            modelBuilder.Entity("Models.Jedinica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("metar")
                        .HasColumnType("float");

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("JedinicaMere");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("FAdministracijaAgencije")
                        .HasColumnType("bit");

                    b.Property<bool>("FAdministrator")
                        .HasColumnType("bit");

                    b.Property<bool>("FKlijent")
                        .HasColumnType("bit");

                    b.Property<bool>("FRadnik")
                        .HasColumnType("bit");

                    b.Property<bool>("FRadnikPregled")
                        .HasColumnType("bit");

                    b.Property<bool>("FVlanikAgencije")
                        .HasColumnType("bit");

                    b.Property<int>("ForeignKeyNV")
                        .HasColumnType("int");

                    b.Property<string>("PhotoFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ime")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("korsinikAgencijaID")
                        .HasColumnType("int");

                    b.Property<int>("ocena")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("plata")
                        .HasColumnType("int");

                    b.Property<string>("prezime")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("recenzijaZaAngenciju")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("timRadnikaID")
                        .HasColumnType("int");

                    b.Property<string>("tipKorsinika")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("korsinikAgencijaID");

                    b.HasIndex("timRadnikaID");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Models.Meseci", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("mesec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Meseci");
                });

            modelBuilder.Entity("Models.PodtipStvari", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("cena")
                        .HasColumnType("int");

                    b.Property<string>("naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("tipStvariID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("tipStvariID");

                    b.ToTable("PodTipovi");
                });

            modelBuilder.Entity("Models.Pregled", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("adresa")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("datum")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("klijentID")
                        .HasColumnType("int");

                    b.Property<double>("latitude")
                        .HasColumnType("float");

                    b.Property<double>("longitude")
                        .HasColumnType("float");

                    b.Property<int?>("pregeldAgencijaID")
                        .HasColumnType("int");

                    b.Property<int?>("pregledRadnikID")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("vreme")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("klijentID");

                    b.HasIndex("pregeldAgencijaID");

                    b.HasIndex("pregledRadnikID");

                    b.ToTable("Pregled");
                });

            modelBuilder.Entity("Models.Prostorija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ilustracija")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("komentar")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("selidbaID")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tipProstorijeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("selidbaID");

                    b.HasIndex("tipProstorijeID");

                    b.ToTable("Prostorije");
                });

            modelBuilder.Entity("Models.Selidba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("adresaDo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("adresaOd")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("cena")
                        .HasColumnType("float");

                    b.Property<string>("datum")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("klijentID")
                        .HasColumnType("int");

                    b.Property<string>("komentarSelidba")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ocena")
                        .HasColumnType("int");

                    b.Property<int?>("pregledID")
                        .HasColumnType("int");

                    b.Property<string>("recenzijaSelidba")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("selidbaAgendijaID")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("timRadnikaID")
                        .HasColumnType("int");

                    b.Property<string>("tipSelidbe")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("klijentID");

                    b.HasIndex("pregledID");

                    b.HasIndex("selidbaAgendijaID");

                    b.HasIndex("timRadnikaID");

                    b.ToTable("Selidbe");
                });

            modelBuilder.Entity("Models.Stvar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("cena")
                        .HasColumnType("float");

                    b.Property<double>("dubina")
                        .HasColumnType("float");

                    b.Property<int?>("jedinicaMereID")
                        .HasColumnType("int");

                    b.Property<int>("kolicina")
                        .HasColumnType("int");

                    b.Property<int?>("podtipID")
                        .HasColumnType("int");

                    b.Property<int?>("prostorijaID")
                        .HasColumnType("int");

                    b.Property<double>("sirina")
                        .HasColumnType("float");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("visina")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("jedinicaMereID");

                    b.HasIndex("podtipID");

                    b.HasIndex("prostorijaID");

                    b.ToTable("Stvari");
                });

            modelBuilder.Entity("Models.TimMesec", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("brojSelidbi")
                        .HasColumnType("int");

                    b.Property<int?>("mesecID")
                        .HasColumnType("int");

                    b.Property<double>("prihod")
                        .HasColumnType("float");

                    b.Property<int?>("timID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("mesecID");

                    b.HasIndex("timID");

                    b.ToTable("TimMeseci");
                });

            modelBuilder.Entity("Models.TimRadnika", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("brojSelidbi")
                        .HasColumnType("int");

                    b.Property<string>("naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("timRadnikaAgencijaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("timRadnikaAgencijaID");

                    b.ToTable("TimRadnika");
                });

            modelBuilder.Entity("Models.TipProstorije", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("slika")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("TipoviProstorije");
                });

            modelBuilder.Entity("Models.TipStvari", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("ID");

                    b.ToTable("TipoviStvari");
                });

            modelBuilder.Entity("Models.ZauzetiTermini", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("datum")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("ZauzetiTermini");
                });

            modelBuilder.Entity("Models.ZauzetiTerminiSelidba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("datum")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("ZauzetiTerminiSelidba");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.HasOne("Models.AgencijaOpsta", "korsinikAgencija")
                        .WithMany("agencijaKorisnici")
                        .HasForeignKey("korsinikAgencijaID");

                    b.HasOne("Models.TimRadnika", "timRadnika")
                        .WithMany("timRadnikaRadnici")
                        .HasForeignKey("timRadnikaID");

                    b.Navigation("korsinikAgencija");

                    b.Navigation("timRadnika");
                });

            modelBuilder.Entity("Models.PodtipStvari", b =>
                {
                    b.HasOne("Models.TipStvari", "tipStvari")
                        .WithMany("podtipStvari")
                        .HasForeignKey("tipStvariID");

                    b.Navigation("tipStvari");
                });

            modelBuilder.Entity("Models.Pregled", b =>
                {
                    b.HasOne("Models.Korisnik", "klijent")
                        .WithMany("pregledKlijent")
                        .HasForeignKey("klijentID");

                    b.HasOne("Models.AgencijaOpsta", "pregeldAgencija")
                        .WithMany("agencijaPregledi")
                        .HasForeignKey("pregeldAgencijaID");

                    b.HasOne("Models.Korisnik", "pregledRadnik")
                        .WithMany("PregledRadnik")
                        .HasForeignKey("pregledRadnikID");

                    b.Navigation("klijent");

                    b.Navigation("pregeldAgencija");

                    b.Navigation("pregledRadnik");
                });

            modelBuilder.Entity("Models.Prostorija", b =>
                {
                    b.HasOne("Models.Selidba", "selidba")
                        .WithMany("selidbaProstorije")
                        .HasForeignKey("selidbaID");

                    b.HasOne("Models.TipProstorije", "tipProstorije")
                        .WithMany("tipProstorije")
                        .HasForeignKey("tipProstorijeID");

                    b.Navigation("selidba");

                    b.Navigation("tipProstorije");
                });

            modelBuilder.Entity("Models.Selidba", b =>
                {
                    b.HasOne("Models.Korisnik", "klijent")
                        .WithMany("kijentSelidbe")
                        .HasForeignKey("klijentID");

                    b.HasOne("Models.Pregled", "pregled")
                        .WithMany()
                        .HasForeignKey("pregledID");

                    b.HasOne("Models.AgencijaOpsta", "selidbaAgendija")
                        .WithMany("agencijaSelidbe")
                        .HasForeignKey("selidbaAgendijaID");

                    b.HasOne("Models.TimRadnika", "timRadnika")
                        .WithMany("timRadnikaSelidbe")
                        .HasForeignKey("timRadnikaID");

                    b.Navigation("klijent");

                    b.Navigation("pregled");

                    b.Navigation("selidbaAgendija");

                    b.Navigation("timRadnika");
                });

            modelBuilder.Entity("Models.Stvar", b =>
                {
                    b.HasOne("Models.Jedinica", "jedinicaMere")
                        .WithMany("jedinicaStvari")
                        .HasForeignKey("jedinicaMereID");

                    b.HasOne("Models.PodtipStvari", "podtip")
                        .WithMany("podtipStvari")
                        .HasForeignKey("podtipID");

                    b.HasOne("Models.Prostorija", "prostorija")
                        .WithMany("prostorijaStvari")
                        .HasForeignKey("prostorijaID");

                    b.Navigation("jedinicaMere");

                    b.Navigation("podtip");

                    b.Navigation("prostorija");
                });

            modelBuilder.Entity("Models.TimMesec", b =>
                {
                    b.HasOne("Models.Meseci", "mesec")
                        .WithMany("mesecTim")
                        .HasForeignKey("mesecID");

                    b.HasOne("Models.TimRadnika", "tim")
                        .WithMany("timMesec")
                        .HasForeignKey("timID");

                    b.Navigation("mesec");

                    b.Navigation("tim");
                });

            modelBuilder.Entity("Models.TimRadnika", b =>
                {
                    b.HasOne("Models.AgencijaOpsta", "timRadnikaAgencija")
                        .WithMany("agencijaTimoviRadnika")
                        .HasForeignKey("timRadnikaAgencijaID");

                    b.Navigation("timRadnikaAgencija");
                });

            modelBuilder.Entity("Models.AgencijaOpsta", b =>
                {
                    b.Navigation("agencijaKorisnici");

                    b.Navigation("agencijaPregledi");

                    b.Navigation("agencijaSelidbe");

                    b.Navigation("agencijaTimoviRadnika");
                });

            modelBuilder.Entity("Models.Jedinica", b =>
                {
                    b.Navigation("jedinicaStvari");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Navigation("kijentSelidbe");

                    b.Navigation("pregledKlijent");

                    b.Navigation("PregledRadnik");
                });

            modelBuilder.Entity("Models.Meseci", b =>
                {
                    b.Navigation("mesecTim");
                });

            modelBuilder.Entity("Models.PodtipStvari", b =>
                {
                    b.Navigation("podtipStvari");
                });

            modelBuilder.Entity("Models.Prostorija", b =>
                {
                    b.Navigation("prostorijaStvari");
                });

            modelBuilder.Entity("Models.Selidba", b =>
                {
                    b.Navigation("selidbaProstorije");
                });

            modelBuilder.Entity("Models.TimRadnika", b =>
                {
                    b.Navigation("timMesec");

                    b.Navigation("timRadnikaRadnici");

                    b.Navigation("timRadnikaSelidbe");
                });

            modelBuilder.Entity("Models.TipProstorije", b =>
                {
                    b.Navigation("tipProstorije");
                });

            modelBuilder.Entity("Models.TipStvari", b =>
                {
                    b.Navigation("podtipStvari");
                });
#pragma warning restore 612, 618
        }
    }
}
