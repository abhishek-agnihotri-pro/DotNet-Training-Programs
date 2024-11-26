namespace DLL_CustomerService_For_MOQ_test
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IList<Customer> _customerList = new List<Customer>();
        public int Add(Customer customer)
        {
            customer.Id = _customerList.Max(x => x.Id) + 1;
            _customerList.Add(customer);
            return customer.Id;
        }

        public void Delete(int id)
        {
            var cust = Get(id);
            if(cust != null) _customerList.Remove(cust);
        }

        public Customer? Get(int id)
        {
            return _customerList.FirstOrDefault(x => x.Id == id);
        }

        public Customer? Search(string email)
        {
            return _customerList.FirstOrDefault(c => c.Email == email);
        }

        public void SendSms()
        {
            
        }

        public int Update(Customer customer)
        {
            var cust = Get(customer.Id);
            if(cust != null){
                cust.Address = customer.Address;
                cust.Email = customer.Email;
                cust.Name = customer.Name;
            }
            return customer.Id;
        }
    }
}