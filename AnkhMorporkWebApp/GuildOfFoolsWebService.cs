using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AnkhMorporkApp.Guilds;
using AnkhMorporkApp.Models;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp
{
    public class GuildOfFoolsWebService:IFoolsGuildWebService
    {
        private readonly IMapper mapper;
        private readonly GuildOfFools foolService;

        public GuildOfFoolsWebService(IMapper mapper, GuildOfFools foolService)
        {
            this.mapper = mapper;
            this.foolService = foolService;
        }

        public Player InteractionWithPlayer(string action, decimal sum, decimal balance)
        {
          
            try
            {
                PlayerDTO _player =  foolService.InteractionWithPlayer(action, sum, balance );
                return mapper.Map<Player>(_player);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}