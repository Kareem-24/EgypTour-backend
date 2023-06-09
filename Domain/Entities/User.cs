﻿using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
     public class User
    {
        public int Id { get; private set; }
        public string Fname { get; private set; }

        public string Lname { get; private set; }
        public string Email { get; private set; }

        public string UserName { get; private set; }

        public string  Password { get; private set; }

        public string ProfilePictureUrl { get; private set; }


        public string Phone { get; private set; }

        public virtual List<Messege> SentMessages { get; private set; } = new();

        public virtual List<Messege> RecievedMessages { get; private set; } = new();
        public byte[] PasswordHash { get; private set; }
        public byte[] PasswordSalt { get; private set; }

        public User(string fname, string lname, string email, string usernameName, string password, string profilePictureUrl, string phone)
        {
            Fname=fname;
            Lname=lname;
            Email=email;
            UserName=usernameName;
            Password=password;
            ProfilePictureUrl=profilePictureUrl;
            Phone=phone;
        }

        public User()
        {
        }

        public void EncryptPassword(byte[] passwordHash, byte[] passwordSalt)
        {
            this.PasswordHash= passwordHash;
            this.PasswordSalt= passwordSalt;
        }

        public void UploadImage(string imageUrl)
        {
            this.ProfilePictureUrl = imageUrl;
        }

        public void UpdateInfo(UserDTO userDTO)
        {
            if (userDTO == null)
            {
                return;
            }
            this.Fname = userDTO.Fname;
            this.Lname = userDTO.Lname;
            this.Email = userDTO.Email;
            this.UserName = userDTO.UsernameName;
            this.Password = userDTO.Password;
            this.Phone = userDTO.Phone;                
        }
    }
}
