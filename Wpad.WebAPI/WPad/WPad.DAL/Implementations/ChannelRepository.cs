﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPad.Core.Entities;
using WPad.Core.Interfaces;
using WPad.DAL.Context;

namespace WPad.DAL.Implementations
{
    public class ChannelRepository : Repository<Channel>, IChannelRepository
    {
        public ChannelRepository(AppDbContext context) : base(context)
        {
        }
    }
}
