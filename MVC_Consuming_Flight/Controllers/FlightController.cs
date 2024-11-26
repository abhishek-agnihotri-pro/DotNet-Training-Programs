using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using MVC_Consuming_Flight.Model;
using Newtonsoft.Json;

namespace MVC_Consuming_Flight.Controllers;

public class FlightController : Controller
{
    Uri BaseAddress = new Uri("http://localhost:5255/api");
    private readonly HttpClient _client;
    public FlightController()
    {
        _client = new HttpClient();
        _client.BaseAddress = BaseAddress;
    }
    [HttpGet]
    public ActionResult Index()
    {
        List<Flight> flights = new List<Flight>();
        HttpResponseMessage res = _client.GetAsync(_client.BaseAddress + "/flight").Result;
        if (res.IsSuccessStatusCode)
        {
            string data = res.Content.ReadAsStringAsync().Result;
            flights = JsonConvert.DeserializeObject<List<Flight>>(data);
        }
        return View(flights);
    }
    [HttpGet]
    public ActionResult Details(int id)
    {
        try
        {
            Flight flights = new Flight();
            HttpResponseMessage res = _client.GetAsync(_client.BaseAddress + "/flight/" + id).Result;
            if (res.IsSuccessStatusCode)
            {
                string data = res.Content.ReadAsStringAsync().Result;
                flights = JsonConvert.DeserializeObject<Flight>(data);
            }
            return View(flights);

        }
        catch (Exception ex)
        {
            TempData["errormsg"] = ex.Message;
            return View();
        }
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Create(Flight model)
    {
        try
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage res = _client.PostAsync(_client.BaseAddress + "/flight", content).Result;
            if (res.IsSuccessStatusCode)
            {
                TempData["successmsg"] = "new Flight Added";
                return RedirectToAction("Index");
            }
        }
        catch (Exception ex)
        {
            TempData["errormsg"] = ex.Message;
            return View();
        }
        return View();

    }
    [HttpGet]
    public ActionResult Edit(int id)
    {
        try
        {
            Flight flight = new Flight();
            HttpResponseMessage res = _client.GetAsync(_client.BaseAddress + "/flight/" + id).Result;
            if (res.IsSuccessStatusCode)
            {
                string data = res.Content.ReadAsStringAsync().Result;
                flight = JsonConvert.DeserializeObject<Flight>(data);
            }
            return View(flight);
        }
        catch (Exception ex)
        {
            TempData["errormsg"] = ex.Message;
            return View();
        }
    }
    [HttpPost]
    public async Task<ActionResult> Edit(int id, Flight model)
    {
        try
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage res = await _client.PutAsync(_client.BaseAddress + "/flight/update/" + id, content);
            Console.WriteLine(res);
            if (res.IsSuccessStatusCode)
            {
                TempData["successmsg"] = "User details updated successfully";
                return RedirectToAction("Index");
            }
        }
        catch (Exception ex)
        {
            TempData["errormsg"] = ex.Message;
            return View();
        }
        return View();

    }
    [HttpGet]
    public async Task<ActionResult> Delete(int id)
    {
        try
        {
            Flight flight = new Flight();
            HttpResponseMessage res = await _client.DeleteAsync(_client.BaseAddress + "/flight/RemoveFlight/" + id);
            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            TempData["errormsg"] = ex.Message;
            return View();
        }
    }
}