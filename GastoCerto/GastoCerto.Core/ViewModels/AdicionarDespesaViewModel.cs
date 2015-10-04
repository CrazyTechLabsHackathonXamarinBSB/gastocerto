using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.PictureChooser;
using Cirrious.MvvmCross.ViewModels;
using GastoCerto.Core.Modelo;
using GastoCerto.Core.Repositorio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GastoCerto.Core.ViewModels
{
    public class AdicionarDespesaViewModel : MvxViewModel
    {
        public Despesa Despesa { get; private set; }

        public AdicionarDespesaViewModel()
        {
            Despesa = new Despesa();
        }

        public ICommand SalvarCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    var r = Mvx.GetSingleton<DespesaRepositorio>();
                    r.Inserir(Despesa);
                    Close(this);
                });
            }
        }

        public ICommand PegarFotoCommand
        {
            get
            {
                return new MvxCommand(async () =>
                    {
                        try
                        {
                            var picktureChooser = Mvx.Resolve<IMvxPictureChooserTask>();

                            var stream = await picktureChooser.TakePictureAsync(480, 80);

                            var memoryStream = new MemoryStream();
                            await stream.CopyToAsync(memoryStream);
                            PictureBytes = memoryStream.ToArray();

                            Despesa.Foto = Convert.ToBase64String(PictureBytes);

                            Debug.WriteLine(Despesa.Foto);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                            throw;
                        }
                    });
            }

        }

        private byte[] _pictureBytes;
        public byte[] PictureBytes { get { return _pictureBytes; } private set { _pictureBytes = value; RaisePropertyChanged(() => PictureBytes); } }
    }
}
