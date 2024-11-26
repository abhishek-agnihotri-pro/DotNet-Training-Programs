namespace DLL_CustomerService_For_MOQ_test
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository){
            _repository = repository;
        }
        public int SaveCustomer(Customer customer){
            if(customer == null){
                throw new ArgumentNullException("Customer cannot be null");
            }
            if(string.IsNullOrWhiteSpace(customer.Name))
            throw new InvalidDataException("Name cannot be empty");
            if(string.IsNullOrWhiteSpace(customer.Email))
            throw new InvalidDataException("Email cannot be empty");
            if(customer.Id == 0 && _repository.Search(customer.Email) != null)
            throw new InvalidDataException("Customer already exists");

            int custId = 0;
            if(customer.Id == 0)
            custId = _repository.Add(customer);
            else
            custId = _repository.Update(customer);

            if(custId > 10)
            _repository.SendSms();

            return custId;
        }
    }
}