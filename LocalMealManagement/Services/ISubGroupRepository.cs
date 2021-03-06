﻿using LocalMealManagement.Models;
using LocalMealManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Services
{
    public interface ISubGroupRepository
    {
        public Task<Boolean> AddSubGroup(string userName , string groupId, CreateSubgroupViewModel model);
        public Task<Boolean> AddMeal(MealModelView model, string subGroupId , string userName , DateTime date);
        public Task<Boolean> UpdateMeal(MealModelView model, string subGroupId, string userName, DateTime date);
        public MealModelView ShowMeal(string subGroupId, string userName, DateTime date);   
        public bool checkMeal(string subGroupId, string userName, DateTime date);   
        public List<MealModelWithUserNameView> SubGroupAllUserMeals(string subGroupId, DateTime date);
        public List<MealModelWithUserNameView> AllUsersMonthlyMeals(string subGroupId, DateTime date);
        public Task<Boolean> AddCost(CostViewModel model, string subGroupId, string AddedBy);
        public List<CostViewModelList> CostList(string subGroupId);
        public List<AllCalculation> allCalculations(string subGroupId);
        public SubGroups GetSubGroupById(int subGroupId);
        public Task<Boolean> Save();
    }
}
