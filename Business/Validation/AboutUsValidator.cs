using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using FluentValidation;

namespace Business.Validation
{
    public class AboutUsValidator : AbstractValidator<AboutUs>
    {
        public AboutUsValidator()
        {
            // HakkimizdaBaslik1 özelliği için kural (boş olmamalı)
            RuleFor(x => x.HakkimizdaBaslik1)
                .NotEmpty().WithMessage("Hakkımızda Başlık 1 alanı boş geçilemez.")
                .Length(5, 150).WithMessage("Hakkımızda Başlık 1, 5 ile 150 karakter arasında olmalıdır.");

            // HakkimizdaBaslik2 özelliği için kural (boş olmamalı)
            RuleFor(x => x.HakkimizdaBaslik2)
                .NotEmpty().WithMessage("Hakkımızda Başlık 2 alanı boş geçilemez.")
                .Length(5, 150).WithMessage("Hakkımızda Başlık 2, 5 ile 150 karakter arasında olmalıdır.");

            // HakkimizdaAciklama1 özelliği için kural (boş olmamalı)
            RuleFor(x => x.HakkimizdaAciklama1)
                .NotEmpty().WithMessage("Hakkımızda Açıklama 1 alanı boş geçilemez.")
                .Length(20, 500).WithMessage("Hakkımızda Açıklama 1, 20 ile 500 karakter arasında olmalıdır.");

            // HakkimizdaAciklama2 özelliği için kural (boş olmamalı)
            RuleFor(x => x.HakkimizdaAciklama2)
                .NotEmpty().WithMessage("Hakkımızda Açıklama 2 alanı boş geçilemez.")
                .Length(20, 500).WithMessage("Hakkımızda Açıklama 2, 20 ile 500 karakter arasında olmalıdır.");

            // HakkimizdaFoto özelliği için kural (boş olmamalı ve geçerli bir URL olmalı)
            RuleFor(x => x.HakkimizdaFoto)
                .NotEmpty().WithMessage("Hakkımızda Fotoğraf alanı boş geçilemez.")
                .Matches(@"^(https?|ftp)://[^\s/$.?#].[^\s]*$").WithMessage("Geçerli bir fotoğraf URL'si girin.");

            // AnasayfaFoto özelliği için kural (boş olmamalı ve geçerli bir URL olmalı)
            RuleFor(x => x.anasayfaFoto)
                .NotEmpty().WithMessage("Anasayfa Fotoğraf alanı boş geçilemez.")
                .Matches(@"^(https?|ftp)://[^\s/$.?#].[^\s]*$").WithMessage("Geçerli bir fotoğraf URL'si girin.");
        }
    }
}

