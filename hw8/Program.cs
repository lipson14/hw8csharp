namespace hw8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Id = 1;
            user.Name = "Mari";
            user.Surname = "lipo";
            user.Age = 150;           
            user.Username = "mari_01";
            user.Email = "mari@mail.com";
            user.Password = "123";      
            user.Phone = "+995555123456";
            user.BirthDate = new DateTime(2010, 14, 8);
            user.Balance = -5;
        }
    }
}
