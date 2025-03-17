using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using FluentValidation;

namespace Business.Validation
{
    public class FleetValidator : AbstractValidator<Fleet>
    {
        public FleetValidator()
        {
            // FiloBaslik (başlık) için kural (boş olmamalı ve uzunluk kontrolü)
            RuleFor(x => x.FiloBaslik)
                .NotEmpty().WithMessage("Filo Başlık alanı boş geçilemez.")
                .Length(5, 150).WithMessage("Filo Başlık, 5 ile 150 karakter arasında olmalıdır.");

            // GemiFoto (fotoğraf URL'si) için kural (boş olmamalı ve geçerli bir URL olmalı)
            RuleFor(x => x.GemiFoto)
                .NotEmpty().WithMessage("Gemi Fotoğraf alanı boş geçilemez.")
                .Matches(@"^(https?|ftp)://[^\s/$.?#].[^\s]*$").WithMessage("Geçerli bir fotoğraf URL'si girin.");

            // GemiAd (gemi adı) için kural (boş olmamalı)
            RuleFor(x => x.GemiAd)
                .NotEmpty().WithMessage("Gemi Adı alanı boş geçilemez.")
                .Length(3, 100).WithMessage("Gemi Adı, 3 ile 100 karakter arasında olmalıdır.");

            // GemiBayrak (bayrak) için kural (boş olmamalı)
            RuleFor(x => x.GemiBayrak)
                .NotEmpty().WithMessage("Gemi Bayrağı alanı boş geçilemez.")
                .Length(2, 50).WithMessage("Gemi Bayrağı, 2 ile 50 karakter arasında olmalıdır.");

            // GemiKapasite için kural (boş olmamalı ve sadece rakam olmalı)
            RuleFor(x => x.GemiKapasite)
                .NotEmpty().WithMessage("Gemi Kapasitesi alanı boş geçilemez.")
                .Matches(@"^\d+$").WithMessage("Gemi Kapasitesi yalnızca rakamlardan oluşmalıdır.");

            // GemiBoy (boy) için kural (boş olmamalı ve geçerli bir sayısal değer olmalı)
            RuleFor(x => x.GemiBoy)
                .NotEmpty().WithMessage("Gemi Boyu alanı boş geçilemez.")
                .Matches(@"^\d+(\.\d{1,2})?$").WithMessage("Gemi Boyu geçerli bir sayısal değer olmalıdır.");

            // GemiGrt (GT) için kural (boş olmamalı ve geçerli bir sayısal değer olmalı)
            RuleFor(x => x.GemiGrt)
                .NotEmpty().WithMessage("Gemi GT alanı boş geçilemez.")
                .Matches(@"^\d+(\.\d{1,2})?$").WithMessage("Gemi GT (Gross Tonnage) geçerli bir sayısal değer olmalıdır.");

            // GemiDwt (DWT) için kural (boş olmamalı ve geçerli bir sayısal değer olmalı)
            RuleFor(x => x.GemiDwt)
                .NotEmpty().WithMessage("Gemi DWT alanı boş geçilemez.")
                .Matches(@"^\d+(\.\d{1,2})?$").WithMessage("Gemi DWT (Dead Weight Tonnage) geçerli bir sayısal değer olmalıdır.");
        }
    }
}
