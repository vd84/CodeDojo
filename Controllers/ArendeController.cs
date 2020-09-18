using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;﻿
using Repos;

namespace ArendeController.Controllers {
  [ApiController]
  [Route ("Arende")]
  class ArendeController {

    private readonly IArendeRepo _arendeRepo;

    public ArendeController (IArendeRepo arendeRepo) {

      this._arendeRepo = arendeRepo;

    }

    [HttpGet ("{id}")]
    public ActionResult<Arende> getArende (int id) {

      return null;

    }

  }
}