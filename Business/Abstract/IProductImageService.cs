﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductImageService
    {
        IResult Add(IFormFile file, ProductImage productImage);
        IResult Delete(ProductImage productImage);

        IResult Update(IFormFile file, ProductImage productImage);

        IDataResult<List<ProductImage>> GetAll();
        IDataResult<List<ProductImage>> GetByProductId(int productId);
        IDataResult<ProductImage> GetByProductImageId(int productImageId);
        
    }
}
