﻿using BeenTogether.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeenTogether.Data
{
    public class BeenTogetherContext :IdentityDbContext<User>
    {
        public BeenTogetherContext(DbContextOptions<BeenTogetherContext> opt):base(opt)
        {

        }

        public DbSet<Love> Loves { get; set; }

        public DbSet<ImageMemory> ImageMemories { get; set; }

        public DbSet<Story> Stories { get; set; }

        public DbSet<Hobby> Hobbies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            // Bỏ tiền tố AspNet của các bảng: mặc định các bảng trong IdentityDbContext có
            // tên với tiền tố AspNet như: AspNetUserRoles, AspNetUser ...
            // Đoạn mã sau chạy khi khởi tạo DbContext, tạo database sẽ loại bỏ tiền tố đó
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        } 
    }
}