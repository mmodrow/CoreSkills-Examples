// <copyright file="HomeController.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using CoreSkills.Examples.AspNetcore.DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CoreSkills.Examples.AspNetcore.DependencyInjection.Controllers
{
    /// <summary>
    /// The default Controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// The collections config.
        /// </summary>
        private readonly CollectionConfig collections;

        /// <summary>
        /// The mixed config.
        /// </summary>
        private readonly MixedConfig mixed;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="collection">The collection config.</param>
        /// <param name="mixed">The mixed config.</param>
        public HomeController(IOptions<CollectionConfig> collection, IOptions<MixedConfig> mixed)
        {
            collections = collection.Value;
            this.mixed = mixed.Value;
        }

        /// <summary>
        /// Renders type and content of different dependency-injectables.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="transient">The transient.</param>
        /// <returns>The View.</returns>
        [Route("{type?}")]
        public IActionResult Index(string type, [FromServices] TransientConfig transient)
        {
            switch (type)
            {
                case "collections":
                    return View(collections);
                case "mixed":
                    return View(mixed);
                case "Transient":
                    return View(transient);
                default:
                    return View(new EmptyBaseConfig());
            }
        }
    }
}
