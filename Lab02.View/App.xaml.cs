using System.Windows;
using AutoMapper;
using Lab02.Model;
using Lab02.View.ViewModel;
using Lab02.View.Base;

namespace Lab02.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        Mapper _mapper;
        DataModel _model;
        DataViewModel _viewModel;

        public App()
        {
            _mapper = new Mapping().Create();
            _model = DataModel.Load();
            _viewModel = _mapper.Map<DataViewModel>(_model);
            var window = new MainWindow() { DataContext = _viewModel };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                _model = _mapper.Map<DataViewModel, DataModel>(_viewModel);
                _model.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }

}
