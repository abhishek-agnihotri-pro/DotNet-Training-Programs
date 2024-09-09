using System.Data;
using System.Data.SqlClient;
using System.Dynamic;

class Program
{
    public static SqlConnection con;
    public static SqlCommand cmd;
    public static SqlDataReader dr;

    public static void GetAllProducts(){
        cmd.Parameters.Clear();
        cmd.CommandText = "select * from product";
        dr = cmd.ExecuteReader();
        while(dr.Read()){
            Console.WriteLine($"Id {dr[0]}, Product Name : {dr[1]}, Quantity : {dr[2]}, Price : {dr[3]}, IsAcitve :{dr[4]}, Expiry : {dr[5]}, Description : {dr[6]}");
        }
        dr.Close();
    }

    public static void InsertProduct(){
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into product(id,name,quantity,price,active,expiry,description) values(@id,@name,@quantity,@price,@active,@expiry,@description)";
            Console.WriteLine("Enter Product Details : ");
            Console.Write("id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("name : ");
            string ?name = Console.ReadLine();
            Console.Write("quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("price : ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("active : ");
            int active = Convert.ToInt32(Console.ReadLine());
            Console.Write("expiry in format(YYYY-MM-DD): ");
            DateTime expiry = Convert.ToDateTime(Console.ReadLine());
            Console.Write("description : ");
            string ?description = Console.ReadLine();

            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@quantity",quantity);
            cmd.Parameters.AddWithValue("@price",price);
            cmd.Parameters.AddWithValue("@active",active);
            cmd.Parameters.AddWithValue("@expiry",expiry);
            cmd.Parameters.AddWithValue("@description",description);

            // con.Open();
            int res = cmd.ExecuteNonQuery();
            if(res == 1)
            Console.WriteLine("Product Added Successfully.");
    }

    public static void DeleteProductByID(){
        cmd.Parameters.Clear();
        Console.Write("Enter Product Id to Delete Product : ");
        int id = Convert.ToInt32(Console.ReadLine());
        cmd.CommandText = "delete from product where id = @id";
        cmd.Parameters.AddWithValue("@id",id);
        int res = cmd.ExecuteNonQuery();
        if(res == 0){
            Console.WriteLine($"Product with id {id} does not exist.");
        }
        else
            Console.WriteLine($"Product with id {id} successfully deleted.");
    }
    public static void UpdateProductPriceByID(){
        cmd.Parameters.Clear();
        Console.Write("Enter Product Id to Update Product Price: ");
        int id = Convert.ToInt32(Console.ReadLine());

        cmd.CommandText = "select * from product where id = @id";
        cmd.Parameters.AddWithValue("@id",id);
        dr = cmd.ExecuteReader();
        while(dr.Read()){
            // Console.WriteLine($"Id {dr[0]}, Product Name : {dr[1]}, Quantity : {dr[2]}, Price : {dr[3]}, IsAcitve :{dr[4]}, Expiry : {dr[5]}, Description : {dr[6]}");
            Console.WriteLine($"Price of product with id {id} is {dr[3]}");
        }
        dr.Close();
        
        cmd.Parameters.Clear();

        Console.Write("Enter Updated Product Price: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());

        cmd.CommandText = "update product set price = @price where id = @id";
        cmd.Parameters.AddWithValue("@id",id);
        cmd.Parameters.AddWithValue("@price",price);
        int res = cmd.ExecuteNonQuery();
        Console.WriteLine(res);
        
    }

    public static void Main(string[] args){
        try{
            con = new SqlConnection("Data Source=YISC1100953LT\\SQLEXPRESS;initial catalog=EDUHUBBB;integrated security=true;trustservercertificate=true");
            Console.WriteLine("Connected Successfully");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            while(true){
                Console.WriteLine("Enter 1 to retrieve Products,");
                Console.WriteLine("Enter 2 to insert product,");
                Console.WriteLine("Enter 3 to deleter product by id,");
                Console.WriteLine("Enter 4 to update Prodct,");
                Console.WriteLine("Enter -1 to exit application.");

                int flag = 0;
                flag = Convert.ToInt32(Console.ReadLine());
                switch(flag){
                    case 1 :
                        GetAllProducts();
                        break;

                    case 2 :
                        InsertProduct();
                        break;

                    case 3 :
                        DeleteProductByID();
                        break;

                    case 4 :
                        UpdateProductPriceByID();
                        break;

                    case -1:
                        Console.WriteLine("See you Soon");
                        break;
                        
                    default :
                        Console.WriteLine("Invalid input");
                        break;
                    
                }
                if(flag == -1){
                    break;
                }
                
            }


            // data source , initail catalog, integrated security, trustservercertificate
            // con = new SqlConnection("Data Source=YISC1100953LT\\SQLEXPRESS;initial catalog=EDUHUBBB;integrated security=true;trustservercertificate=true");
            // Console.WriteLine("Connected Successfully");
            // cmd = new SqlCommand();
            // // cmd = new SqlCommand("Select * from users",con);
            // cmd.Connection = con;

            // cmd.CommandText = "select userid, username, password, role, email from users";
            // cmd.CommandText = "select userid, username, password, role, email from users where userid = @userid";
            // Console.WriteLine("Enter the user ID to retreive : ");
            // int id = Convert.ToInt32(Console.ReadLine());
            // SqlParameter p = new SqlParameter("@userid",SqlDbType.BigInt);

            // p.Value = id;
            // cmd.Parameters.Add(p);
            // con.Open();
            // dr = cmd.ExecuteReader();
            // while(dr.Read()){
            //     Console.WriteLine($"Id {dr[0]} username : {dr[1]} password : {dr[2]} role : {dr[3]}, email {dr[4]}");
            // }

            // Console.WriteLine("Enter User Record");
            // Console.Write("username : ");
            // string username = Console.ReadLine();
            // Console.Write("password : ");
            // string password = Console.ReadLine();
            // Console.Write("role : ");
            // string role = Console.ReadLine();
            // Console.Write("email : ");
            // string email = Console.ReadLine();

            // cmd.CommandText = "insert into users(username,password,role,email) values(@username,@password,@role,@email)";
            // cmd.Parameters.AddWithValue("@username",username);
            // cmd.Parameters.AddWithValue("@password",password);
            // cmd.Parameters.AddWithValue("@role",role);
            // cmd.Parameters.AddWithValue("@email",email);

            // // SqlParameter p = new SqlParameter("@username",SqlDbType.VarChar);
            // // p.Value = username;
            // // cmd.Parameters.Add(p);


            // con.Open();
            // int res = cmd.ExecuteNonQuery();
            // Console.WriteLine(res);
            
        }
        catch(SqlException ex){
            Console.WriteLine(ex.Message);
        }
        finally{
            con.Close();
        }
    }
}