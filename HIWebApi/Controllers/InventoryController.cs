using System.Collections.Generic;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HIWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InventoryController : ControllerBase
{


    [HttpGet]
    public List<Inventory> Get()
    {
        List<Inventory> inventoryList = GetInventory();
        return inventoryList;
    }

    private List<Inventory> GetInventory()
    {
        List<Inventory> retList = new List<Inventory>() {
            new Inventory() {Id = 1, Description = "Table", Count = 2},
            new Inventory() {Id = 2, Description = "Chair", Count = 18},
            new Inventory() {Id = 3, Description = "Desk", Count = 7},
            new Inventory() {Id = 4, Description = "Book Shelf", Count = 1}
        };


        return retList;


    }





}
