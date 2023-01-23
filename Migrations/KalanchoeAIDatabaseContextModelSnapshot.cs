﻿// <auto-generated />
using System;
using KalanchoeAI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KalanchoeAIBackend.Migrations
{
    [DbContext(typeof(KalanchoeAIDatabaseContext))]
    partial class KalanchoeAIDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("KalanchoeAI.Models.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CommunityId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CommunityId");

                    b.ToTable("Channel", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.ChannelComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChannelCommentValue")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ChannelId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.HasIndex("UserId");

                    b.ToTable("ChannelComment", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Chat", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.ChatComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChatId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChatValue")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("ChatComment", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentValue")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PostId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Community", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MediaLink")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Community", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.Follower", b =>
                {
                    b.Property<int>("FollowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("FollowerId");

                    b.HasIndex("UserId");

                    b.ToTable("Follower", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CommunityId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CommunityId");

                    b.HasIndex("UserId");

                    b.ToTable("Member", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("MessageValue")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Message", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("NoteValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PanelId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PanelId");

                    b.ToTable("Note", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.Panel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Panel", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostValue")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Post", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("KalanchoeAI.Models.Channel", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Community", "Community")
                        .WithMany("Channels")
                        .HasForeignKey("CommunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Community");
                });

            modelBuilder.Entity("KalanchoeAI.Models.ChannelComment", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Channel", "Channel")
                        .WithMany("ChannelComments")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("ChannelComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Chat", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Chats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.ChatComment", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Chat", "Chat")
                        .WithMany("ChatComments")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Comment", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Community", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Communities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Follower", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Followers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Member", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Community", "Community")
                        .WithMany("Members")
                        .HasForeignKey("CommunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Members")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Community");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Message", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Note", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Panel", "Panel")
                        .WithMany("Notes")
                        .HasForeignKey("PanelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Panel");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Panel", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Panels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Post", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Channel", b =>
                {
                    b.Navigation("ChannelComments");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Chat", b =>
                {
                    b.Navigation("ChatComments");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Community", b =>
                {
                    b.Navigation("Channels");

                    b.Navigation("Members");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Panel", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("KalanchoeAI.Models.User", b =>
                {
                    b.Navigation("ChannelComments");

                    b.Navigation("Chats");

                    b.Navigation("Comments");

                    b.Navigation("Communities");

                    b.Navigation("Followers");

                    b.Navigation("Members");

                    b.Navigation("Messages");

                    b.Navigation("Panels");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
