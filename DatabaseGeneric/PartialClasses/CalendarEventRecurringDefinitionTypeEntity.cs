using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoSoftware.MonoX.DAL.HelperClasses;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class CalendarEventRecurringDefinitionTypeEntity
    {
        public static MonoSoftware.Web.Workspace.Lookup<CalendarEventRecurringDefinitionTypeEntity> GetLookup()
        {
            return MonoSoftware.Web.Workspace.Lookup<CalendarEventRecurringDefinitionTypeEntity>.GetInstance(CalendarEventRecurringDefinitionTypeFields.Name);
        }

        public bool IsWeekly
        {
            get { return Abrv == "Weekly"; }
        }

        public bool IsMonthly
        {
            get { return Abrv == "Monthly"; }
        }

        public bool IsYearly
        {
            get { return Abrv == "Yearly"; }
        }

        public static class Types
        {
            public static CalendarEventRecurringDefinitionTypeEntity Weekly
            {
                get { return GetLookup().Entities.First(entity => entity.IsWeekly); }
            }

            public static CalendarEventRecurringDefinitionTypeEntity Monthly
            {
                get { return GetLookup().Entities.First(entity => entity.IsMonthly); }
            }

            public static CalendarEventRecurringDefinitionTypeEntity Yearly
            {
                get { return GetLookup().Entities.First(entity => entity.IsYearly); }
            }
        }
    }
}
