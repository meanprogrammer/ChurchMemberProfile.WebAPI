﻿using ChurchMemberProfile.WebAPI.Data;
using ChurchMemberProfile.WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChurchMemberProfile.WebAPI.Controllers
{
    public class MemberProfileController : ApiController
    {
        MemberProfileRepository repository = new MemberProfileRepository();

        // GET api/values
        public IEnumerable<MemberProfile> Get()
        {
            return repository.GetAll();
        }

        // GET api/values/5
        public MemberProfile Get(int id)
        {
            return repository.GetById(id);
        }

        // POST api/values
        public void Post(MemberProfile profile)
        {
            repository.InsertOnSubmit(profile);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            repository.DeleteOnSubmit(id);
        }
    }
}