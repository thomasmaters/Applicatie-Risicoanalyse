using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applicatie_Risicoanalyse.Controls;
using System.Diagnostics;
using System.ComponentModel;

namespace Applicatie_Risicoanalyse.Globals
{
    class ARA_Events
    {
        //Eventhandlers for storing which function to trigger when the event gets called.
        public static event EventHandler<OpenContentFormEvent>          OpenContentFormEventHandler;
        public static event EventHandler<BaseFormSetTopBarFormEvent>    baseFormSetTopBarFormEventHandler;
        public static event EventHandler<SetSideBarButtonSelectedEvent> SetSideBarButtonSelectedEventHandler;
        public static event EventHandler<SideBarAddNewButtonEvent>      SideBarAddNewButtonEventHandler;
        public static event EventHandler<SideBarRemoveNewButtonEvent>   SideBarRemoveNewButtonEventHandler;
        public static event EventHandler<AddRiskToProjectEvent>         AddRiskToProjectEventHandler;
        public static event EventHandler<SideBarAddNewButtonEvent>      SideBarButtonAddedEventHandler;

        public static event EventHandler<NewProjectCreatedEvent>        NewProjectCreatedEventHandler;
        public static event EventHandler<RiskAddedToProjectEvent>       RiskAddedToProjectEventHandler;
        public static event EventHandler<ProjectOpendEvent>             ProjectOpendEventHandler;
        public static event EventHandler<ProjectClosedEvent>            ProjectClosedEventHandler;
        public static event EventHandler<UserLoggedInEvent>             UserLoggedInEventHandler;
        public static event EventHandler<ProjectStateChangedEvent>      ProjectStateChangedEventHandler;
        public static event EventHandler<NewProjectRevisionEvent>       NewProjectRevisionEventHandler;
        public static event EventHandler<ProjectSpecificRiskCreatedEvent> ProjectSpecificRiskCreatedEventHandler;
        public static event EventHandler<NewRiskAddedToStandardEvent>   NewRiskAddedToStandardEventHandler;
        public static event EventHandler<NewRiskVersionEvent>           NewRiskVersionEventHandler;

        public static event EventHandler<NewLogMessageEvent>            NewLogMessageEventHandler;

        //Static function for adding an event to the event handlers.
        public static void triggerOpenContentFormEvent(System.Windows.Forms.Form aForm)
        {
            OpenContentFormEventHandler(aForm, new OpenContentFormEvent(aForm));
        }
        public static void triggerBaseFormSetTopBarEvent(System.Windows.Forms.Form aForm)
        {
            baseFormSetTopBarFormEventHandler(aForm, new BaseFormSetTopBarFormEvent(aForm));
        }
        public static void triggerSideBarButtonAddedEvent(object sender, SideBarAddNewButtonEvent e)
        {
            if (SideBarButtonAddedEventHandler != null)
            {
                SideBarButtonAddedEventHandler(sender, e);
            }
        }
        public static void triggerSetSideBarButtonSelectedEvent(string aIndex)
        {
            if (SetSideBarButtonSelectedEventHandler != null)
            {
                SetSideBarButtonSelectedEventHandler(aIndex, new SetSideBarButtonSelectedEvent(aIndex));
            }
        }
        public static void triggerSideBarAddNewButtonEvent(Applicatie_Risicoanalyse.Controls.ARA_Button aButton, Object FormType)
        {
            if(SideBarAddNewButtonEventHandler != null)
            {
                SideBarAddNewButtonEventHandler(aButton, new SideBarAddNewButtonEvent(aButton,FormType));
            }
        }
        public static void triggerAddRiskToProjectEvent( object sender, int aProjectID, int aRiskID)
        {
            if(AddRiskToProjectEventHandler != null)
            {
                AddRiskToProjectEventHandler(sender, new AddRiskToProjectEvent(aProjectID, aRiskID));
            }
        }
        public static void triggerSideBarRemoveButtonEvent(string buttonText)
        {
            if(SideBarRemoveNewButtonEventHandler != null)
            {
                SideBarRemoveNewButtonEventHandler(new object(), new SideBarRemoveNewButtonEvent(buttonText));
            }
        }

        public static void triggerNewProjectCreatedEvent(int aProjectID)
        {
            Logger.Instance.log(string.Format("{0} created a new project with id {1}.", ARA_Globals.LoggedInUsername, aProjectID));
            if (NewProjectCreatedEventHandler != null)
            {
                NewProjectCreatedEventHandler(new object(), new NewProjectCreatedEvent(aProjectID));
            }
        }
        public static void triggerRiskAddedToProjectEvent(int aProjectID)
        {
            Logger.Instance.log(string.Format("{0} added a risk to project {1}.", ARA_Globals.LoggedInUsername, aProjectID));
            if (RiskAddedToProjectEventHandler != null)
            {
                RiskAddedToProjectEventHandler(new object(), new RiskAddedToProjectEvent(aProjectID));
            }
        }
        public static void triggerProjectOpendEvent(int aProjectID)
        {
            Logger.Instance.log(string.Format("{0} opened project {1}.", ARA_Globals.LoggedInUsername, aProjectID));
            if (ProjectOpendEventHandler != null)
            {
                ProjectOpendEventHandler(new object(), new ProjectOpendEvent(aProjectID));
            }
        }
        public static void triggerProjectClosedEvent()
        {
            Logger.Instance.log(string.Format("{0} closed a project.", ARA_Globals.LoggedInUsername));
            if (ProjectClosedEventHandler != null)
            {
                ProjectClosedEventHandler(new object(), new ProjectClosedEvent());
            }
        }
        public static void triggerUserLoggedInEvent()
        {
            Logger.Instance.log(string.Format("{0} logged in on {1} with application version {2}.", ARA_Globals.LoggedInUsername, ARA_Globals.ARa_Date, ARA_Globals.ApplicationVersion));
            if (UserLoggedInEventHandler != null)
            {
                UserLoggedInEventHandler(new object(), new UserLoggedInEvent());
            }
        }
        public static void triggerProjectStateChangedEvent(int aProjectID, string aState)
        {
            Logger.Instance.log(string.Format("{0} changed the state of project {1} to the state {2}.", ARA_Globals.LoggedInUsername, aProjectID, aState));
            if (ProjectStateChangedEventHandler != null)
            {
                ProjectStateChangedEventHandler(new object(), new ProjectStateChangedEvent(aProjectID, aState));
            }
        }
        public static void triggerNewProjectRevisionEvent(int aRevisionOfProjectID, int aRevison)
        {
            Logger.Instance.log(string.Format("{0} created revsion {2} of project {1}.", ARA_Globals.LoggedInUsername, aRevisionOfProjectID, aRevison));
            if (NewProjectRevisionEventHandler != null)
            {
                NewProjectRevisionEventHandler(new object(), new NewProjectRevisionEvent(aRevisionOfProjectID, aRevison));
            }
        }
        public static void triggerProjectSpecificRiskCreatedEvent(int aRiskID, int aProjectID)
        {
            Logger.Instance.log(string.Format("{0} made risk {1} in project {2} project specific.", ARA_Globals.LoggedInUsername, aRiskID, aProjectID));
            if (ProjectSpecificRiskCreatedEventHandler != null)
            {
                ProjectSpecificRiskCreatedEventHandler(new object(), new ProjectSpecificRiskCreatedEvent(aRiskID, aProjectID));
            }
        }
        public static void triggerNewRiskAddedToStandardEvent(int aRiskID)
        {
            Logger.Instance.log(string.Format("{0} added the new risk {1} to the standard.", ARA_Globals.LoggedInUsername, aRiskID));
            if (NewRiskAddedToStandardEventHandler != null)
            {
                NewRiskAddedToStandardEventHandler(new object(), new NewRiskAddedToStandardEvent(aRiskID));
            }
        }
        public static void triggerNewRiskVersionEvent(int aRiskID, int aVersion)
        {
            Logger.Instance.log(string.Format("{0} created version {2} of standard risk {1}.", ARA_Globals.LoggedInUsername, aRiskID, aVersion));
            if (NewRiskVersionEventHandler != null)
            {
                NewRiskVersionEventHandler(new object(), new NewRiskVersionEvent(aRiskID, aVersion));
            }
        }

        public static void triggerNewLogMessageEvent(string aLogMessage)
        {
            if(NewLogMessageEventHandler != null)
            {
                NewLogMessageEventHandler(new object(), new NewLogMessageEvent(aLogMessage));
            }
        }
    }

    public class NewLogMessageEvent
    {
        public string logMessage { get; private set; }

        public NewLogMessageEvent(string aLogMessage)
        {
            this.logMessage = aLogMessage;
        }
    }

    public class NewRiskVersionEvent
    {
        public int riskID { get; private set; }
        public int version { get; private set; }

        public NewRiskVersionEvent(int aRiskID, int aVersion)
        {
            this.riskID = aRiskID;
            this.version = aVersion;
        }
    }

    public class NewRiskAddedToStandardEvent
    {
        public int riskID { get; private set; }
        public NewRiskAddedToStandardEvent(int aRiskID)
        {
            this.riskID = aRiskID;
        }
    }

    public class ProjectSpecificRiskCreatedEvent
    {
        public int riskID { get; private set; }
        public int projectID { get; private set; }
        public ProjectSpecificRiskCreatedEvent(int aRiskID, int aProjectID)
        {
            this.riskID = aRiskID;
            this.projectID = aProjectID;
        }
    }

    public class NewProjectRevisionEvent
    {
        public int revision { get; private set; }
        public int revisionOfProjectID { get; private set; }
        public NewProjectRevisionEvent(int aRevisionOfProjectID, int aRevison)
        {
            this.revision = aRevison;
            this.revisionOfProjectID = aRevisionOfProjectID;
        }
    }

    public class ProjectStateChangedEvent
    {
        public int projectID { get; private set; }
        public string state { get; private set; }
        public ProjectStateChangedEvent(int aProjectID, string aState)
        {
            this.projectID = aProjectID;
            this.state = aState;
        }
    }

    public class UserLoggedInEvent
    {
        public UserLoggedInEvent()
        {

        }
    }

    public class ProjectClosedEvent
    {
        public ProjectClosedEvent()
        {
        }
    }

    public class ProjectOpendEvent
    {
        public int projectID { get; private set; }
        public ProjectOpendEvent(int aProjectID)
        {
            this.projectID = aProjectID;
        }
    }

    public class SideBarRemoveNewButtonEvent
    {
        public string buttonText { get; private set; }

        private SideBarRemoveNewButtonEvent() { }

        public SideBarRemoveNewButtonEvent(string buttonText)
        {
            this.buttonText = buttonText;
        }
    }

    //Event for opening a form in the main content panel.
    public class OpenContentFormEvent : EventArgs
    {
        public System.Windows.Forms.Form Form { get;  private set; }

        private OpenContentFormEvent() { }

        public OpenContentFormEvent(System.Windows.Forms.Form aForm)
        {
            this.Form = aForm;
        }
    }

    public class BaseFormSetTopBarFormEvent : EventArgs
    {
        public System.Windows.Forms.Form Form { get; private set; }

        private BaseFormSetTopBarFormEvent() { }

        public BaseFormSetTopBarFormEvent(System.Windows.Forms.Form aForm)
        {
            this.Form = aForm;
        }
    }

    //Event for selecting a specific button in the sidebar.
    public class SetSideBarButtonSelectedEvent : EventArgs
    {
        public string Index { get; private set; }

        private SetSideBarButtonSelectedEvent() { }

        public SetSideBarButtonSelectedEvent(string aIndex)
        {
            this.Index = aIndex;
        }
    }

    //Event for adding a new button to the sidebar.
    public class SideBarAddNewButtonEvent : EventArgs
    {
        public Applicatie_Risicoanalyse.Controls.ARA_Button Button { get; private set; }
        public Object FormType { get; private set; }

        private SideBarAddNewButtonEvent() { }

        public SideBarAddNewButtonEvent(Applicatie_Risicoanalyse.Controls.ARA_Button aButton, Object FormType)
        {
            this.Button = aButton;
            this.FormType = FormType;
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

    public class MeasureItemChangedEvent : EventArgs
    {
        public int measureID { get; private set; }
        public CheckState checkState { get; private set; }

        private MeasureItemChangedEvent()
        {

        }

        public MeasureItemChangedEvent(int measureID, CheckState checkState)
        {
            this.measureID = measureID;
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

    public class ExposedPersonChangedEvent : EventArgs
    {
        public int exposedPersonID { get; private set; }
        public CheckState checkedState { get; private set; }

        private ExposedPersonChangedEvent()
        {

        }

        public ExposedPersonChangedEvent(int exposedPersonID, CheckState checkedState)
        {
            this.exposedPersonID = exposedPersonID;
            this.checkedState = checkedState;
        }
    }

    public class RiskComponentGroupAndTypeChangedEvent : EventArgs
    {
        public string componentGroup { get; private set; }
        public string componentType { get; private set; }

        private RiskComponentGroupAndTypeChangedEvent()
        {

        }

        public RiskComponentGroupAndTypeChangedEvent(string componentGroup, string componentType)
        {
            this.componentGroup = componentGroup;
            this.componentType = componentType;
        }
    }

    public class GenerateRiskReportEventArgs : DoWorkEventArgs
    {
        public int projectID { get; private set; }
        public string sortingKey { get; private set; }
        public object newDocumentLocation { get; private set; }
        public byte[] riskPageTemplateLocation { get; private set; }
        public byte[] indexPageTemplateLocation { get; private set; }
        public byte[] frontPageTemplateLocation { get; private set; }

        private GenerateRiskReportEventArgs() : base(new object())
        {

        }

        public GenerateRiskReportEventArgs(int projectID, string sortingKey, object newDocumentLocation, byte[] riskPageTemplateLocation, byte[] indexPageTemplateLocation, byte[] frontPageTemplateLocation) : base(new object())
        {
            this.projectID                  = projectID;
            this.sortingKey                 = sortingKey;
            this.newDocumentLocation        = newDocumentLocation;
            this.riskPageTemplateLocation   = riskPageTemplateLocation;
            this.indexPageTemplateLocation  = indexPageTemplateLocation;
            this.frontPageTemplateLocation  = frontPageTemplateLocation;
        }
    }

    public class GenerateRemainingRiskReportEvent : DoWorkEventArgs
    {
        public int projectID { get; private set; }
        public string sortingKey { get; private set; }
        public object newDocumentLocation { get; private set; }
        public byte[] remainingRiskPageTemplateLocation { get; private set; }
        public byte[] indexPageTemplateLocation { get; private set; }
        public byte[] frontPageTemplateLocation { get; private set; }
        public byte[] remainingRiskHeaderPageTemplateLocation { get; private set; }

        private GenerateRemainingRiskReportEvent() : base(new object())
        {

        }

        public GenerateRemainingRiskReportEvent(int projectID, string sortingKey, object newDocumentLocation, byte[] remainingRiskHeaderPageTemplateLocation, byte[] remainingRiskPageTemplateLocation, byte[] indexPageTemplateLocation, byte[] frontPageTemplateLocation) : base(new object())
        {
            this.projectID = projectID;
            this.sortingKey = sortingKey;
            this.newDocumentLocation = newDocumentLocation;
            this.remainingRiskHeaderPageTemplateLocation = remainingRiskHeaderPageTemplateLocation;
            this.remainingRiskPageTemplateLocation = remainingRiskPageTemplateLocation;
            this.indexPageTemplateLocation = indexPageTemplateLocation;
            this.frontPageTemplateLocation = frontPageTemplateLocation;
        }
    }

    public class GeneratePerformanceLevelReportEvent : DoWorkEventArgs
    {
        public int projectID { get; private set; }
        public string sortingKey { get; private set; }
        public object newDocumentLocation { get; private set; }
        public byte[] riskPageTemplateLocation { get; private set; }
        public byte[] frontPageTemplateLocation { get; private set; }

        private GeneratePerformanceLevelReportEvent() : base(new object())
        {

        }

        public GeneratePerformanceLevelReportEvent(int projectID, string sortingKey, object newDocumentLocation, byte[] riskPageTemplateLocation, byte[] frontPageTemplateLocation) : base(new object())
        {
            this.projectID = projectID;
            this.sortingKey = sortingKey;
            this.newDocumentLocation = newDocumentLocation;
            this.riskPageTemplateLocation = riskPageTemplateLocation;
            this.frontPageTemplateLocation = frontPageTemplateLocation;
        }
    }

    public class NewProjectCreatedEvent
    {
        public int projectID { get; private set; }
        public NewProjectCreatedEvent(int aProjectID)
        {
            this.projectID = aProjectID;
        }
    }

    public class RiskAddedToProjectEvent
    {
        public int projectID { get; private set; }
        private RiskAddedToProjectEvent() { }

        public RiskAddedToProjectEvent(int aProjectID)
        {
            this.projectID = aProjectID;
        }
    }
}
