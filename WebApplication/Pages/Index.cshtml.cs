using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using BikeStore.Models;
using Microsoft.AspNetCore.Components;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        [Inject]
        protected HttpClient Http { get; set; }
        public List<Manufacturer> Manufacturers { get; private set; }
        public string ErrorString { get; set; }
        protected string ModalTitle { get; set; }

        private Boolean _isDelete = false;
        private Boolean _isAdd = false;
        
        protected string SearchString { get; set; }
        
        protected async Task OnInitAsync()
        {
            await GetManufacturers();
        }
        
        private async Task GetManufacturers()
        {
            var res = await Http.GetAsync("api/Manufacturer/GetAll");
            if (res.IsSuccessStatusCode)
            {
                Manufacturers = await res.Content.ReadFromJsonAsync<List<Manufacturer>>();
                ErrorString = null;
            }
            else
            {
                ErrorString = $"There was an error getting the manufacturers: {res.ReasonPhrase}";
            }
                
            /*manufacturers = await _manufacturerController.GetAll() as List<Manufacturer>;
            return manufacturers;*/
            
            /*var mornicThing = await Http.GetAsync($"{Url}/api/manufacturer");
            return JsonSerializer.Deserialize<List<Manufacturer>>(mornicThing.Content.CopyTo(this.manufacturers));  GetStringAsync());
            var res = GetManufacturerNamesAsync();
            
            HttpResponseMessage res = await Http.GetAsync("api/Manufacturer/GetAll");
            res.EnsureSuccessStatusCode();
            var responseText = await res.Content.ReadAsStreamAsync(<Manufacturer>); ReadAsStringAsync();
            Manufacturer manufacturer = res.Content.ReadAsStreamAsync();
            Manufacturer manufacturer = await res.Content.ReadAsAsync(typeof(Manufacturer));
            yourTypeInstance = await res.Content.ReadAsStream<Manufacturer>();
            var bf = new BinaryFormatter();
            object manufacturer = bf.Deserialize(responseText);
            return object;
            object yourTypeInstance = await response.Content.ReadAsAsync(typeof(YourType));
            
            return manufacturer;
            return data;*/
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
        protected void closeModal()
        {
            this._isAdd = false;
            this._isDelete = false;
        }
    }
}