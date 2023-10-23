using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DOANDATVEMAYBAY2023.Models;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<FormLienHe> FormLienHes { get; set; }

    public virtual DbSet<HanhKhach> HanhKhaches { get; set; }

    public virtual DbSet<SanBay> SanBays { get; set; }

    public virtual DbSet<ThongTinChuyenBay> ThongTinChuyenBays { get; set; }

    public virtual DbSet<Ve> Ves { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-9KFA5D6\\SQLEXPRESS;Database=DatVeMayBay;user id=sa;password=123456;trusted_connection=true;encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminUse__3214EC078A2308E7");

            entity.ToTable("AdminUser");

            entity.Property(e => e.Id)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MatKhau)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TaiKhoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<FormLienHe>(entity =>
        {
            entity.HasKey(e => e.MaForm).HasName("PK__FormLien__E3C18CD1741DD15B");

            entity.ToTable("FormLienHe");

            entity.Property(e => e.MaForm)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HoTen).HasMaxLength(30);
            entity.Property(e => e.TieuDe).HasMaxLength(30);
        });

        modelBuilder.Entity<HanhKhach>(entity =>
        {
            entity.HasKey(e => e.MaHk).HasName("PK__HanhKhac__2725A6E7680C8FC1");

            entity.ToTable("HanhKhach");

            entity.Property(e => e.MaHk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaHK");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenKhachHang).HasMaxLength(30);
        });

        modelBuilder.Entity<SanBay>(entity =>
        {
            entity.HasKey(e => e.MaSbay).HasName("PK__SanBay__8A737AA11B86A804");

            entity.ToTable("SanBay");

            entity.Property(e => e.MaSbay)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSBay");
            entity.Property(e => e.TenSbay)
                .HasMaxLength(30)
                .HasColumnName("TenSBay");
            entity.Property(e => e.TenTinhThanh).HasMaxLength(30);
        });

        modelBuilder.Entity<ThongTinChuyenBay>(entity =>
        {
            entity.HasKey(e => e.MaCb).HasName("PK__ThongTin__27258E1A2FD8821F");

            entity.ToTable("ThongTinChuyenBay");

            entity.Property(e => e.MaCb)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaCB");
            entity.Property(e => e.GheLoai1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GheLoai2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MaSbayDen)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSBayDen");
            entity.Property(e => e.MaSbayDi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSBayDi");
            entity.Property(e => e.MaVe)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NgayCatCanh).HasColumnType("datetime");
            entity.Property(e => e.NgayHaCanh).HasColumnType("datetime");
            entity.Property(e => e.TenCb)
                .HasMaxLength(30)
                .HasColumnName("TenCB");

            entity.HasOne(d => d.MaSbayDenNavigation).WithMany(p => p.ThongTinChuyenBayMaSbayDenNavigations)
                .HasForeignKey(d => d.MaSbayDen)
                .HasConstraintName("FK__ThongTinC__MaSBa__3E52440B");

            entity.HasOne(d => d.MaSbayDiNavigation).WithMany(p => p.ThongTinChuyenBayMaSbayDiNavigations)
                .HasForeignKey(d => d.MaSbayDi)
                .HasConstraintName("FK__ThongTinC__MaSBa__3D5E1FD2");

            entity.HasOne(d => d.MaVeNavigation).WithMany(p => p.ThongTinChuyenBays)
                .HasForeignKey(d => d.MaVe)
                .HasConstraintName("FK__ThongTinCh__MaVe__3F466844");
        });

        modelBuilder.Entity<Ve>(entity =>
        {
            entity.HasKey(e => e.MaVe).HasName("PK__Ve__2725100FE0F48E6A");

            entity.ToTable("Ve");

            entity.Property(e => e.MaVe)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LoaiGhe)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaHk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaHK");
            entity.Property(e => e.ThoiGianDat).HasColumnType("datetime");
            entity.Property(e => e.ThoiGianDi).HasColumnType("datetime");

            entity.HasOne(d => d.MaHkNavigation).WithMany(p => p.Ves)
                .HasForeignKey(d => d.MaHk)
                .HasConstraintName("FK__Ve__MaHK__38996AB5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
