﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace Unican.smartHome
{
	/// <summary>
	/// DomainModel smartHomeDomainModel
	/// An item to create a model of a smart home 
	/// </summary>
	[DslDesign::DisplayNameResource("Unican.smartHome.smartHomeDomainModel.DisplayName", typeof(global::Unican.smartHome.smartHomeDomainModel), "Unican.smartHome.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Unican.smartHome.smartHomeDomainModel.Description", typeof(global::Unican.smartHome.smartHomeDomainModel), "Unican.smartHome.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("01317cd4-1135-4994-9f06-60232d8d15e6")]
	public partial class smartHomeDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// smartHomeDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x01317cd4, 0x1135, 0x4994, 0x9f, 0x06, 0x60, 0x23, 0x2d, 0x8d, 0x15, 0xe6);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public smartHomeDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(SmartHome),
				typeof(Floor),
				typeof(Room),
				typeof(SmartEnergy),
				typeof(LightSimulation),
				typeof(BlindSimulation),
				typeof(Heater),
				typeof(Window),
				typeof(Blind),
				typeof(Light),
				typeof(SmartHomeHasFloors),
				typeof(FloorHasRooms),
				typeof(SmartHomeHasSmartEnergy),
				typeof(SmartHomeHasLightSimulation),
				typeof(SmartHomeHasBlindSimulation),
				typeof(RoomHasHeaters),
				typeof(RoomHasWindows),
				typeof(WindowHasBlinds),
				typeof(RoomHasLights),
				typeof(smartHomeDiagram),
				typeof(Connector),
				typeof(FloorShape),
				typeof(roomShape),
				typeof(WindowShape),
				typeof(HeaterShape),
				typeof(SmartEnergyShape),
				typeof(LightShape),
				typeof(BlindShape),
				typeof(LightSimulationShape),
				typeof(BlindSimulationShape),
				typeof(global::Unican.smartHome.FixUpDiagram),
				typeof(global::Unican.smartHome.ConnectorRolePlayerChanged),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(Floor), "Name", Floor.NameDomainPropertyId, typeof(Floor.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Room), "Name", Room.NameDomainPropertyId, typeof(Room.NamePropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(SmartHomeHasFloors), "SmartHome", SmartHomeHasFloors.SmartHomeDomainRoleId),
				new DomainRolePlayerInfo(typeof(SmartHomeHasFloors), "Element", SmartHomeHasFloors.ElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(FloorHasRooms), "Floor", FloorHasRooms.FloorDomainRoleId),
				new DomainRolePlayerInfo(typeof(FloorHasRooms), "Room", FloorHasRooms.RoomDomainRoleId),
				new DomainRolePlayerInfo(typeof(SmartHomeHasSmartEnergy), "SmartHome", SmartHomeHasSmartEnergy.SmartHomeDomainRoleId),
				new DomainRolePlayerInfo(typeof(SmartHomeHasSmartEnergy), "SmartEnergy", SmartHomeHasSmartEnergy.SmartEnergyDomainRoleId),
				new DomainRolePlayerInfo(typeof(SmartHomeHasLightSimulation), "SmartHome", SmartHomeHasLightSimulation.SmartHomeDomainRoleId),
				new DomainRolePlayerInfo(typeof(SmartHomeHasLightSimulation), "LightSimulation", SmartHomeHasLightSimulation.LightSimulationDomainRoleId),
				new DomainRolePlayerInfo(typeof(SmartHomeHasBlindSimulation), "SmartHome", SmartHomeHasBlindSimulation.SmartHomeDomainRoleId),
				new DomainRolePlayerInfo(typeof(SmartHomeHasBlindSimulation), "BlindSimulation", SmartHomeHasBlindSimulation.BlindSimulationDomainRoleId),
				new DomainRolePlayerInfo(typeof(RoomHasHeaters), "Room", RoomHasHeaters.RoomDomainRoleId),
				new DomainRolePlayerInfo(typeof(RoomHasHeaters), "Heater", RoomHasHeaters.HeaterDomainRoleId),
				new DomainRolePlayerInfo(typeof(RoomHasWindows), "Room", RoomHasWindows.RoomDomainRoleId),
				new DomainRolePlayerInfo(typeof(RoomHasWindows), "Window", RoomHasWindows.WindowDomainRoleId),
				new DomainRolePlayerInfo(typeof(WindowHasBlinds), "Window", WindowHasBlinds.WindowDomainRoleId),
				new DomainRolePlayerInfo(typeof(WindowHasBlinds), "Blind", WindowHasBlinds.BlindDomainRoleId),
				new DomainRolePlayerInfo(typeof(RoomHasLights), "Room", RoomHasLights.RoomDomainRoleId),
				new DomainRolePlayerInfo(typeof(RoomHasLights), "Light", RoomHasLights.LightDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(21);
				createElementMap.Add(typeof(SmartHome), 0);
				createElementMap.Add(typeof(Floor), 1);
				createElementMap.Add(typeof(Room), 2);
				createElementMap.Add(typeof(SmartEnergy), 3);
				createElementMap.Add(typeof(LightSimulation), 4);
				createElementMap.Add(typeof(BlindSimulation), 5);
				createElementMap.Add(typeof(Heater), 6);
				createElementMap.Add(typeof(Window), 7);
				createElementMap.Add(typeof(Blind), 8);
				createElementMap.Add(typeof(Light), 9);
				createElementMap.Add(typeof(smartHomeDiagram), 10);
				createElementMap.Add(typeof(Connector), 11);
				createElementMap.Add(typeof(FloorShape), 12);
				createElementMap.Add(typeof(roomShape), 13);
				createElementMap.Add(typeof(WindowShape), 14);
				createElementMap.Add(typeof(HeaterShape), 15);
				createElementMap.Add(typeof(SmartEnergyShape), 16);
				createElementMap.Add(typeof(LightShape), 17);
				createElementMap.Add(typeof(BlindShape), 18);
				createElementMap.Add(typeof(LightSimulationShape), 19);
				createElementMap.Add(typeof(BlindSimulationShape), 20);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Unican.smartHome.smartHomeDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new SmartHome(partition, propertyAssignments);
				case 1: return new Floor(partition, propertyAssignments);
				case 2: return new Room(partition, propertyAssignments);
				case 3: return new SmartEnergy(partition, propertyAssignments);
				case 4: return new LightSimulation(partition, propertyAssignments);
				case 5: return new BlindSimulation(partition, propertyAssignments);
				case 6: return new Heater(partition, propertyAssignments);
				case 7: return new Window(partition, propertyAssignments);
				case 8: return new Blind(partition, propertyAssignments);
				case 9: return new Light(partition, propertyAssignments);
				case 10: return new smartHomeDiagram(partition, propertyAssignments);
				case 11: return new Connector(partition, propertyAssignments);
				case 12: return new FloorShape(partition, propertyAssignments);
				case 13: return new roomShape(partition, propertyAssignments);
				case 14: return new WindowShape(partition, propertyAssignments);
				case 15: return new HeaterShape(partition, propertyAssignments);
				case 16: return new SmartEnergyShape(partition, propertyAssignments);
				case 17: return new LightShape(partition, propertyAssignments);
				case 18: return new BlindShape(partition, propertyAssignments);
				case 19: return new LightSimulationShape(partition, propertyAssignments);
				case 20: return new BlindSimulationShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(9);
				createElementLinkMap.Add(typeof(SmartHomeHasFloors), 0);
				createElementLinkMap.Add(typeof(FloorHasRooms), 1);
				createElementLinkMap.Add(typeof(SmartHomeHasSmartEnergy), 2);
				createElementLinkMap.Add(typeof(SmartHomeHasLightSimulation), 3);
				createElementLinkMap.Add(typeof(SmartHomeHasBlindSimulation), 4);
				createElementLinkMap.Add(typeof(RoomHasHeaters), 5);
				createElementLinkMap.Add(typeof(RoomHasWindows), 6);
				createElementLinkMap.Add(typeof(WindowHasBlinds), 7);
				createElementLinkMap.Add(typeof(RoomHasLights), 8);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Unican.smartHome.smartHomeDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new SmartHomeHasFloors(partition, roleAssignments, propertyAssignments);
				case 1: return new FloorHasRooms(partition, roleAssignments, propertyAssignments);
				case 2: return new SmartHomeHasSmartEnergy(partition, roleAssignments, propertyAssignments);
				case 3: return new SmartHomeHasLightSimulation(partition, roleAssignments, propertyAssignments);
				case 4: return new SmartHomeHasBlindSimulation(partition, roleAssignments, propertyAssignments);
				case 5: return new RoomHasHeaters(partition, roleAssignments, propertyAssignments);
				case 6: return new RoomHasWindows(partition, roleAssignments, propertyAssignments);
				case 7: return new WindowHasBlinds(partition, roleAssignments, propertyAssignments);
				case 8: return new RoomHasLights(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "Unican.smartHome.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return smartHomeDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (smartHomeDomainModel.resourceManager == null)
				{
					smartHomeDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(smartHomeDomainModel).Assembly);
				}
				return smartHomeDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return smartHomeDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return smartHomeDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (smartHomeDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new smartHomeCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					smartHomeDomainModel.copyClosure = copyFilter;
				}
				return smartHomeDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (smartHomeDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new smartHomeDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					smartHomeDomainModel.removeClosure = removeFilter;
				}
				return smartHomeDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::Unican.smartHome.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::Unican.smartHome.ConnectorRolePlayerChanged));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::Unican.smartHome.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::Unican.smartHome.ConnectorRolePlayerChanged));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class smartHomeDeleteClosure : smartHomeDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public smartHomeDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class smartHomeDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public smartHomeDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::Unican.smartHome.SmartHomeHasFloors.ElementDomainRoleId, true);
			DomainRoles.Add(global::Unican.smartHome.FloorHasRooms.RoomDomainRoleId, true);
			DomainRoles.Add(global::Unican.smartHome.SmartHomeHasSmartEnergy.SmartEnergyDomainRoleId, true);
			DomainRoles.Add(global::Unican.smartHome.SmartHomeHasLightSimulation.LightSimulationDomainRoleId, true);
			DomainRoles.Add(global::Unican.smartHome.SmartHomeHasBlindSimulation.BlindSimulationDomainRoleId, true);
			DomainRoles.Add(global::Unican.smartHome.RoomHasHeaters.HeaterDomainRoleId, true);
			DomainRoles.Add(global::Unican.smartHome.RoomHasWindows.WindowDomainRoleId, true);
			DomainRoles.Add(global::Unican.smartHome.WindowHasBlinds.BlindDomainRoleId, true);
			DomainRoles.Add(global::Unican.smartHome.RoomHasLights.LightDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class smartHomeCopyClosure : smartHomeCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public smartHomeCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class smartHomeCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public smartHomeCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}
