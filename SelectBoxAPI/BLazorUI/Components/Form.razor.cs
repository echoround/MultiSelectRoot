using SelectBoxDomain.Models;
using Microsoft.AspNetCore.Components.Web;
using System.Net.Http.Json;
using System.Text.Json;

namespace BLazorUI.Components
{
    public partial class Form
    {

        private const string _serviceEndpoint = "https://localhost:44348/api/";

        private IEnumerable<string> options { get; set; } = new HashSet<string>() { };
        private string? exceptionMessage;
        private Sector[]? sectors = Array.Empty<Sector>();
        bool success = false;
        bool multiselectHover = false;
        private Customer customer { get; set; }
        private Sector? sector { get; set; }
        // To emulate unique user being logged in.      
        public string? CustomerAuth { get; set; }


        protected override async Task OnInitializedAsync()
        {
            try
            {
                // To emulate unique user being logged in.
                CustomerAuth = Guid.NewGuid().ToString("N")[..10];
                customer = new Customer();

                sectors = (await Http.GetFromJsonAsync<string[]>(_serviceEndpoint + "sectors")).Select(x => new Sector { SectorName = x }).ToArray();

                customer.CustomerName = "";

                string json = JsonSerializer.Serialize(customer);
                var route = $"form/{json}";
            }
            catch (NotSupportedException exception)
            {
                exceptionMessage = exception.Message;
            }
        }


        private async Task PostForm()
        {

            // To prevent multiple submits because of async delay (even if the button is not yet disabled in the UI because of network delay, 
            // we can prevent handling the event twice by checking this bool).
            if (success)
                return;

            success = true;

            try
            {
                customer.CustomerAuth = CustomerAuth;
                var temp = customer;               
                using var response = await Http.PostAsJsonAsync(_serviceEndpoint + "customer/", temp);

            }

            catch (NotSupportedException exception)
            {
                exceptionMessage = exception.Message;
            }



        }

        private async Task EditForm()
        {
            success = false;

            try
            {
                customer = await Http.GetFromJsonAsync<Customer>(_serviceEndpoint + "customer/" + CustomerAuth);                        
            }

            catch (NotSupportedException exception)
            {
                exceptionMessage = exception.Message;
            }


        }

        private void ChangeUser()
        {
            // To emulate unique user being logged in.
            // The customer GUID (customerauth) property is to emulate user credentials and have a unique user with forms per "session".
            // I did this to have a specific customer to get when repopulating the form for editing.
            // Change it to add new forms from "new" customers.
            CustomerAuth = Guid.NewGuid().ToString("N")[..10];

        }

        private string GetMultiSelectionText(List<string> selectedValues)
        {
            if (!multiselectHover)
            {
                return $"{string.Join(", ", selectedValues.Select(x => x))}";
            }
            else
            {
                return $"{selectedValues.Count} sector{(selectedValues.Count > 1 || selectedValues.Count == 0 ? "s have" : " has")} been selected";
            }
        }

        protected void OnMouseOver(MouseEventArgs mouseEvent)
        {
            if (!multiselectHover)
            {
                multiselectHover = true;
                StateHasChanged();
            }
        }

        protected void OnMouseOut(MouseEventArgs mouseEvent)
        {
            multiselectHover = false;
            StateHasChanged();
        }



    }
}
