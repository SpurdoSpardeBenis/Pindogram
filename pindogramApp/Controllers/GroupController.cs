﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pindogramApp.Model;


namespace pindogramApp.Controllers
{
    [Route("api/[controller]")]
    public class GroupController : Controller
    {
        private readonly PindogramDataContext _pindogramDataContext;

        public GroupController(PindogramDataContext pindogramDataContext)
        {
            _pindogramDataContext = pindogramDataContext;
        }

        [HttpGet]
        [Route("/api/[controller]/GetSingle/{id}")]
        public Group GetGroupName(int id)
        {
            return _pindogramDataContext.Groups.FirstOrDefault(x=> x.Id == id);
        }

        /// <summary>
        /// Com
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/[controller]/GetAll")]
        public IEnumerable<Group> GetAll()
        {
            return _pindogramDataContext.Groups;
        }
    }
}