using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applicatie_Risicoanalyse.Controls;
using System.Diagnostics;

namespace Applicatie_Risicoanalyse.Globals
{
    class ARA_Events
    {
        //Eventhandlers for storing which function to trigger when the event gets called.
        public static event EventHandler<OpenContentFormEventArgs> openContentFormEventHandler;
        public static event EventHandler<SetSideBarButtonSelectedEventArgs> SetSideBarButtonSelectedEventHandler;
        public static event EventHandler<SideBarAddNewButtonEvent> SideBarAddNewButtonEventHandler;
        public static event EventHandler<AddRiskToProjectEvent> AddRiskToProjectEventHandler;

        //Static function for adding an event to the event handlers.
        public static void onOpenContentFormEvent(System.Windows.Forms.Form aForm)
        {
            openContentFormEventHandler(aForm, new OpenContentFormEventArgs(aForm));
        }
        public static void onSetSideBarButtonSelectedEvent(string aIndex)
        {
            SetSideBarButtonSelectedEventHandler(aIndex, new SetSideBarButtonSelectedEventArgs(aIndex));
        }
        public static void onSideBarAddNewButtonEvent(Applicatie_Risicoanalyse.Controls.ARA_Button aButton)
        {
            SideBarAddNewButtonEventHandler(aButton, new SideBarAddNewButtonEvent(aButton));
        }
        public static void onAddRiskToProjectEvent( object sender, int aProjectID, int aRiskID)
        {
            if(AddRiskToProjectEventHandler != null)
            {
                AddRiskToProjectEventHandler(sender, new AddRiskToProjectEvent(aProjectID, aRiskID));
            }
        }
    }

    //Event for opening a form in the main content panel.
    public class OpenContentFormEventArgs : EventArgs
    {
        public System.Windows.Forms.Form Form { get;  private set; }

        private OpenContentFormEventArgs() { }

        public OpenContentFormEventArgs(System.Windows.Forms.Form aForm)
        {
            this.Form = aForm;
        }
    }

    //Event for selecting a specific button in the sidebar.
    public class SetSideBarButtonSelectedEventArgs : EventArgs
    {
        public string Index { get; private set; }

        private SetSideBarButtonSelectedEventArgs() { }

        public SetSideBarButtonSelectedEventArgs(string aIndex)
        {
            this.Index = aIndex;
        }
    }

    //Event for adding a new button to the sidebar.
    public class SideBarAddNewButtonEvent : EventArgs
    {
        public Applicatie_Risicoanalyse.Controls.ARA_Button Button { get; private set; }

        private SideBarAddNewButtonEvent() { }

        public SideBarAddNewButtonEvent(Applicatie_Risicoanalyse.Controls.ARA_Button aButton)
        {
            this.Button = aButton;
        }
    }

    public class AddRiskToProjectEvent : EventArgs
    {
        public int projectID { get; private set; }
        public int riskID { get; private set; }

        private AddRiskToProjectEvent() { }

        public AddRiskToProjectEvent(int aProjectID, int aRiskID)
        {
            this.projectID = aProjectID;
            this.riskID = aRiskID;
        }
    }

    public class MesureItemChangedEvent : EventArgs
    {
        public int mesureID { get; private set; }
        public CheckState checkState { get; private set; }

        private MesureItemChangedEvent()
        {

        }

        public MesureItemChangedEvent(int mesureID, CheckState checkState)
        {
            this.mesureID = mesureID;
            this.checkState = checkState;
        }
    }

    public class RiskEstimationChangedEvent : EventArgs
    {
        public int estimationID { get; private set; }
        public string groupName { get; private set; }

        private RiskEstimationChangedEvent()
        {

        }

        public RiskEstimationChangedEvent(int estimationID, string groupName)
        {
            this.estimationID = estimationID;
            this.groupName = groupName;
        }
    }

    public class DangerChangedEvent : EventArgs
    {
        public int dangerID { get; private set; }
        public int dangerSourceID { get; private set; }
        public string hazardSituation { get; private set; }
        public string hazardEvent { get; private set; }

        private DangerChangedEvent()
        {

        }

        public DangerChangedEvent(int dangerID, int dangerSourceID, string hazardSituation, string hazardEvent)
        {
            this.dangerID = dangerID;
            this.dangerSourceID = dangerSourceID;
            this.hazardSituation = hazardSituation;
            this.hazardEvent = hazardEvent;
        }
    }
}
