﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Web.Models.ViewModels;

namespace MVC.Web.Models.Products.ViewModels
{
    public record ProductCreateWrapperModel
    {
        public ProductCreateViewModel ProductViewModel { get; set; } = new();

        public CategoryCreateViewModel CategoryViewModel { get; set; } = new();
    }


    public record ProductCreateViewModel
    {
        public ProductCreateViewModel()
        {
        }

        public ProductCreateViewModel(List<SelectModel> isPublisherDurationList)
        {
            IsPublisherDurationList = isPublisherDurationList;
        }


        //public ProductCreateViewModel(List<(string text,int value)> isPublisherList)
        //{

        //}
        //public ProductCreateViewModel(List<Tuple<string,int>> isPublisherList)
        //{

        //}
        [Display(Name = "Ürün resmi:")] public IFormFile ImageFile { get; set; } = default!;


        [Display(Name = "Ürün yayınlanma süresi :")]
        public List<SelectModel> IsPublisherDurationList { get; set; } = default!;

        public int IsPublisherDurationId { get; set; }


        [Display(Name = "Ürün ismi :")] public string Name { get; set; } = default!;


        [DataType(DataType.Currency)]
        [Display(Name = "Ürün fiyatı :")]
        public decimal Price { get; set; }

        [Display(Name = "Ürün açıklaması :")] public string? Description { get; set; }


        [Display(Name = "Ürün stok adet :")] public int StockCount { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Ürün resim url :")]
        public string? PictureUrl { get; set; }


        [Display(Name = "Ürün yayınlansın mı? :")]
        public bool IsPublish { get; set; }
    }

    public record CategoryCreateViewModel
    {
        [Display(Name = "Kategori seç :")] public SelectList CategorySelectList { get; set; } = default!;


        public int CategoryId { get; set; }


        //[Display(Name = "Kategori ismi :")] public string Name { get; set; } = default!;
    }
}