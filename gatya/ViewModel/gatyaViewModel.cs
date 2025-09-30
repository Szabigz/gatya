using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using gatya.Model;

namespace gatya.ViewModel
{
    public class gatyaViewModel : ViewModelBase
    {
        private gatyaModel _model;

        public string Size { get; private set; }


        public gatyaViewModel(gatyaModel model){
            _model = model;
            _model.meretChanged += Model_meretChanged;
        }

        private void Model_meretChanged(object sebder, gatyaEventArgs e)
        {
            Size = e.meret;
            OnPropertyChanged(nameof(Size));
        }

        public int Width
        {
            get
            {
                return _model.Width;
            }
            set
            {
                if (_model.Width != value)
                {
                    _model.setWidth(value);
                    OnPropertyChanged(nameof(Width));
                }
            }
        }
        public int Height
        {
            get
            {
                return _model.Height;
            }
            set
            {
                if (_model.Height != value)
                {
                    _model.setHeight(value);
                    OnPropertyChanged(nameof(Height));
                }
            }
        }
    }
}
