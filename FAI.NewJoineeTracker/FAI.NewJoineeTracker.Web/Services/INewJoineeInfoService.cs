using FAI.NewJoineeTracker.Web.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAI.NewJoineeTracker.Web.Services
{
    public interface INewJoineeInfoService
    {
        List<NewJoineeInfo> GetAllNewJoinees();
        NewJoineeInfo GetNewJoineeInfo(int Id);
        NewJoineeInfo CreateNewJoineeInfo(NewJoineeInfo newJoineeInfo);
        NewJoineeInfo UpdateNewJoineeInfo(NewJoineeInfo newJoineeInfo);
        NewJoineeInfo DeleteNewJoineeInfo(NewJoineeInfo newJoineeInfo);
    }
}