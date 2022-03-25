﻿using Batu.Repository.Repository;
using Batu.Services.DataServiceLayer;
using DataAccesLayer.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp100.ViewComponents.Contact
{
    public class Contact:ViewComponent
    {
        private readonly DataServiceLayer m_dataServiceLayer = new(new DataAcces(new ContactRepository()));

        public IViewComponentResult Invoke()
        {

            return View(m_dataServiceLayer.GetContactList());
        }
    }
}

/*
 * 
 * @using Batu.Entites.Concrete
@model List<ContactEntity>
<div class="col-md-6" data-aos="fade-left" data-aos-delay="300">
    @foreach (var item in Model)
    {
        <div class="mt-3 px-1">



            <div class="h5">@item.Title</div>
            <p>@item.Description </p>

        </div>
        <div class="mt-53 px-1">
            <div class="row">
                <div class="col-sm-2">
                    <div class="pb-1">Email:</div>
                </div>
                <div class="col-sm-10">
                    <div class="pb-1 fw-bolder">@item.Mail</div>
                </div>
                <div class="col-sm-2">
                    <div class="pb-1">Skype:</div>
                </div>

                <div class="col-sm-2">
                    <div class="pb-1">Phone:</div>
                </div>
                <div class="col-sm-10">
                    <div class="pb-1 fw-bolder">@item.PhoneNumber</div>
                </div>
            </div>
            </div>
            }
        </div> 
    </div>
 * 
 */
