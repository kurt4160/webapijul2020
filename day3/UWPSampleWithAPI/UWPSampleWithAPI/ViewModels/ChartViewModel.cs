using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using UWPSampleWithAPI.Core.Models;
using UWPSampleWithAPI.Core.Services;
using UWPSampleWithAPI.Helpers;

namespace UWPSampleWithAPI.ViewModels
{
    public class ChartViewModel : Observable
    {
        public ObservableCollection<DataPoint> Source { get; } = new ObservableCollection<DataPoint>();

        public ChartViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await SampleDataService.GetChartDataAsync();
            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
