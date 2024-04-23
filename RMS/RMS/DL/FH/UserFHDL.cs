using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using RMS.BL;
using RMS.UI;
using System.Drawing;

namespace RMS.DL
{
    public class UserFHDL : IUserDL, IPhotoDL
    {
        private readonly string path = UtilityFunctions.GetPath("Users.txt");
        public void SaveUser(User user)
        {
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{user.GetEmail()}, {user.GetPassword()}, {user.GetRole()}");
            }
        }

        public bool EmailAlreadyExists(string email)
        {
            if (!File.Exists(path))
                return false;

            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4 && parts[1].Trim() == email)
                    return true;
            }
            return false;
        }

        public int GetUserID(string email)
        {
            if (!File.Exists(path))
                return -1;

            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4 && parts[1].Trim() == email)
                    return Convert.ToInt32(parts[0].Trim());
            }
            return -1;
        }

        public int GetUserID(int id)
        {
            if (!File.Exists(path))
                return -1;

            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4 && parts[0].Trim() == id.ToString())
                    return Convert.ToInt32(parts[0].Trim());
            }
            return -1;
        }

        public int GetUserIDEmp(int id)
        {
            string path = UtilityFunctions.GetPath("Employees.txt");
            if (!File.Exists(path))
                return -1;

            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 7 && parts[0].Trim() == id.ToString())
                    return Convert.ToInt32(parts[6].Trim());
            }
            return -1;
        }

        public string SearchUserForRole(string email, string password)
        {
            if (!File.Exists(path))
                return "";
            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4 && parts[1].Trim() == email && parts[2].Trim() == password)
                    return parts[3].Trim();
            }
            return "";
        }

        public void SaveImage(int userID)
        {
            string defaultImagePath = "..//..//images//user-solid.png";
            string userImagePath = UtilityFunctions.GetImagesPath($"User{userID}Image.jpg");

            try
            {
                byte[] defaultPhoto = File.ReadAllBytes(defaultImagePath);
                File.WriteAllBytes(userImagePath, defaultPhoto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving default image: {ex.Message}");
            }
        }

        public void UpdateImage(int userID, byte[] photo)
        {
            string imagePath = UtilityFunctions.GetImagesPath($"User{userID}Image.jpg");
            try
            {
                File.WriteAllBytes(imagePath, photo);
                Console.WriteLine("Image updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating image: {ex.Message}");
            }
        }

        public Image LoadImage(int userID)
        {
            string imagePath = UtilityFunctions.GetImagesPath($"User{userID}Image.jpg");
            try
            {
                if (File.Exists(imagePath))
                {
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        return Image.FromStream(ms);
                    }
                }
                else
                {
                    Console.WriteLine("Image not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
                return null;
            }
        }
    }
}
