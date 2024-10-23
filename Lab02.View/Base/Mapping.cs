using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Lab02.Model;
using Lab02.View.ViewModel;

namespace Lab02.View.Base
{
    public class Mapping
    {
        public Mapper Create()
        {
            return new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<BookingViewModel, Booking>();
                cfg.CreateMap<Booking, BookingViewModel>();

                cfg.CreateMap<GuestViewModel, Guest>();
                cfg.CreateMap<Guest, GuestViewModel>();

                cfg.CreateMap<HotelViewModel, Hotel>();
                cfg.CreateMap<Hotel, HotelViewModel>();
            }));
        }
    }
}
