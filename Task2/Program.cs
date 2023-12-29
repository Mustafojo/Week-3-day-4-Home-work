PhotoBook photo = new PhotoBook();
System.Console.WriteLine("Kitob az " + photo.GetNumberPages() + " varak iborat ast");


System.Console.Write("Kitobi chand varaka ba shumo lozim ast ? ");
PhotoBook photo1 = new PhotoBook(Convert.ToInt32(Console.ReadLine()));


BigPhotoBook bigPhoto = new BigPhotoBook();
System.Console.Write("Kitobi kalontarini mo az ");
System.Console.Write(bigPhoto.GetNumberPages());
System.Console.WriteLine(" varak iborad ast ");
