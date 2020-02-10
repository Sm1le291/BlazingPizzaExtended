using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BlazingPizza.DomainModels;

namespace BlazingPizza.Server.Controllers
{
    [ApiController]
    [Route("pizzas")]
    public class PizzasController : ControllerBase
    {
        // GET
        public IEnumerable<BasePizza>  Get()
        {
            return new[]
            {
                new BasePizza()
                {
                    BasePrice = 500,
                    Description = "Самая вкусная пицца которую вы пробовали",
                    Id = 0,
                    ImageUrl = "img/pizzas/pepperoni.jpg"
                },
                new BasePizza()
                {
                    BasePrice = 400,
                    Description = "Вот эта точно вкусная",
                    Id = 1,
                    ImageUrl = "img/pizzas/meaty.jpg"
                },
            };
        }
    }
}