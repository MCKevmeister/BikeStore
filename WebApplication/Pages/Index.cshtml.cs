using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text.Json;
using BikeStore.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Manufacturer> Manufacturers;
        public  string ErrorString { get; set; }

        public IndexModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task GetManufacturers()
        {
            //Manufacturers = await _manufacturerRepository.GetAll()
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:5001/api/Manufacturer/GetAll");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                await using var responseStream = await response.Content.ReadAsStreamAsync();
                Manufacturers = await JsonSerializer.DeserializeAsync<IEnumerable<Manufacturer>>(responseStream);
            }
            else
            {
                ErrorString = $"There was an error getting the manufacturers: {response.ReasonPhrase}";
            }
        }
    }

    /*protected void AddEmp()
    {
        emp = new Employee();
        this.ModalTitle = "Add Employee";
        this.isAdd = true;
    }*/

        /*protected async Task EditEmployee(string ID)
        {
            emp = await Http.GetJsonAsync<Employee>("/api/Employee/Details/" + ID);
            this.ModalTitle = "Edit Employee";
            this.isAdd = true;
        }*/

        /*protected async Task SaveEmployee()
        {
            if (emp.Id != null)
            {
                await Http.SendJsonAsync(HttpMethod.Put, "api/Employee/Edit", emp);
            }
            else
            {
                await Http.SendJsonAsync(HttpMethod.Post, "/api/Employee/Create", emp);

            }
            this.isAdd = false;
            await GetEmployee();
        }*/

        /*protected async Task DeleteConfirm(string ID)
        {
            emp = await Http.GetJsonAsync<Employee>("/api/Employee/Details/" + ID);
            this.isDelete = true;
        }

        protected async Task DeleteEmployee(string ID)
        {
            await Http.DeleteAsync("api/Employee/Delete/" + ID);

            this.isDelete = false;
            await GetEmployee();
        }*/
        /*protected void CloseModal()
        {
            this._isAdd = false;
            this._isDelete = false;
        }*/
    }