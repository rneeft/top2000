﻿#nullable enable

using Chroomsoft.Top2000.Features.Searching;

namespace Chroomsoft.Top2000.WindowsApp.Searching
{
    public interface ISortGroupNameProvider
    {
        string GetNameForGroup(IGroup group);

        string GetNameForSort(ISort sort);
    }
}
