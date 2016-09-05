﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.Models
{
    public class RemoteService
    {
        public string GetRemoteData()
        {
            Thread.Sleep(2000);
            return "Hello my world";
        }

        public async Task<string> GetRemoteDataAsync()
        {
            return await Task<string>.Factory.StartNew(() => {

                Thread.Sleep(2000);
                return "Hello my world";
            });
        }

        //public async Task<string>.Factory.StartNew(()=>{
        //    Thread.Sleer(2000);
        //    return "Hello from the other side of the world";
        //});

    }
}