﻿using System.Collections.Generic;
using Music_Shop_Management;

namespace MusicShopManager.Engine.Factories
{
    using System;
    using MusicShopManager.Interfaces;
    using MusicShopManager.Interfaces.Engine;
    using MusicShopManager.Models;

    public class MusicShopFactory : IMusicShopFactory
    {
        public IMusicShop CreateMusicShop(string name)
        {
            return new global::MusicShop.Models.MusicShop(name);
        }
    }
}
