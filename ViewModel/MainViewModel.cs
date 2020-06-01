using RoboboKitchenProject.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using RoboboKitchenProject.Model;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RoboboKitchenProject.DAL.Impl.Mappers;
using RoboboKitchenProject.DAL.Impl;
using RoboboKitchenProject.Entity;
using RoboboKitchenProject.BLL.Class;

namespace RoboboKitchenProject.ModelView
{
    
    public class MainViewModel : INotifyPropertyChanged
    {
        
        private UnitOfWorkImpl unitOfWork;

        public DishMapper dishMapper;
        public SpealizationMapper spealizationMapper;
        public CookSpealizationMapper cookSpealizationMapper;
        public CookMapper cookMapper;
        public List<Cook> cooks;
        public Order order;
        List<List<string>> specs;
        private List<Dish> _DishList;
        private List<Spealization> _Spealizations;
        public OrderMapper orderMapper;
        int id;

        private Dish _ItemSelect;
        public MainViewModel()
        {
            Order order = new Order();


            dishMapper = new DishMapper();
            spealizationMapper = new SpealizationMapper();
            cookSpealizationMapper = new CookSpealizationMapper();
            orderMapper = new OrderMapper();
            cookMapper = new CookMapper();
            specs = new List<List<string>>();

            List<string> a = new List<string>();
            List<string> b = new List<string>();
            List<string> c = new List<string>();

            a.Add("MexicanFood");
            b.Add("MexicanFood");
            c.Add("MexicanFood");
            b.Add("ItalianFood");
            c.Add("ItalianFood");
            c.Add("AsianFood");

            specs.Add(a);
            specs.Add(b);
            specs.Add(c);

            cooks = new List<Cook>();
            _DishList = new List<Dish>();
            _Spealizations = new List<Spealization>();
            unitOfWork = new UnitOfWorkImpl();
            
            MapDishList();
            AddSpealizations();
            AddCook();
            //AddSpecs();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void MapDishList()
        {
            _DishList = dishMapper.Map(unitOfWork.Dishes.ListEntities());
            
           

        }
        public void AddSpealizations()
        {
            foreach (Spealization spealization in spealizationMapper.Map(unitOfWork.Specialization.ListEntities()))
            {
                Spealization s = new Spealization() { ID = spealization.ID, Name = spealization.Name };
                _Spealizations.Add(s);
            }
        }
        public void AddCook()
        {
            foreach (Cook cook in cookMapper.Map(unitOfWork.Cooks.ListEntities()))
            {

                Kitchen.AddCook(new Cook(cook.ID, cook.Name, cook.CookQualification, specs[cook.ID-1]));
            }
            
           

        }
        public void AddSpecs()
        {
            foreach (CookSpealization cookspealization in cookSpealizationMapper.Map(unitOfWork.CookSpecialization.ListEntities()))
            {

                cooks[cookspealization.CookID - 1].Specialization.Add("AsianFood");
               
            }
        }
        public List<Dish> DishList
        {
            get => _DishList;
            set
            {
                _DishList = value;
                OnPropertyChanged("DishList");

            }
        }


        public Dish ItemSelect
        {
            get => _ItemSelect;
            set
            {
                _ItemSelect = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        RelayCommand _OrderCommand;
        public ICommand OrderCommand
        {
            get
            {
                if (_OrderCommand == null)
                    _OrderCommand = new RelayCommand(ExecuteOderCommand, CanExecuteOderCommand);
                return _OrderCommand;
            }
        }
        private void ExecuteOderCommand(object parameter)
        {
            try
            {
                
                Order order = new Order(ItemSelect);
                MessageBox.Show($"Thank you for order, you ordered: {order.DishName.Name}. Please Wait for: {CalculateCookingTime.ReturnTime(order.OrderCook, order.DishName).ToString()} to get your food! Enjoy your meal!");
                Kitchen.AddOrder(order, order.OrderCook);
                orderMapper.DeMap(order, unitOfWork);
            }
            catch
            {
                
            }
        }
        private bool CanExecuteOderCommand(object parameter)
        {
            return true;
        }

    }
}
