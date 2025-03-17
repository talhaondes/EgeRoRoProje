using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using FluentValidation;

namespace Business.Validation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            // iletisimBaslik için kural(boş olmamalı)
            RuleFor(x => x.iletisimBaslik)
                .NotEmpty().WithMessage("İletişim Başlık alanı boş geçilemez.")
                .Length(5, 150).WithMessage("İletişim Başlık, 5 ile 150 karakter arasında olmalıdır.");

            // Adress (Adres) için kural (boş olmamalı)
            RuleFor(x => x.Adress)
                .NotEmpty().WithMessage("Adres alanı boş geçilemez.")
                .Length(10, 300).WithMessage("Adres, 10 ile 300 karakter arasında olmalıdır.");

            // Telefon numarası için kural (boş olmamalı ve geçerli formatta olmalı)
            RuleFor(x => x.Telefon)
                .NotEmpty().WithMessage("Telefon alanı boş geçilemez.")
                .Matches(@"^\+?\d{10,15}$").WithMessage("Geçerli bir telefon numarası girin. (Örneğin: +905555555555)");

            // Email için kural (boş olmamalı ve geçerli bir e-posta adresi olmalı)
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("E-posta alanı boş geçilemez.")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi girin.");

            // Anasayfa fotoğrafı için kural (boş olmamalı ve geçerli bir URL olmalı)
            RuleFor(x => x.anasayfaFoto)
                .NotEmpty().WithMessage("Anasayfa Fotoğraf alanı boş geçilemez.")
                .Matches(@"^(https?|ftp)://[^\s/$.?#].[^\s]*$").WithMessage("Geçerli bir fotoğraf URL'si girin.");
        }

    }
}
