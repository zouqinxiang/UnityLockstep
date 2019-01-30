//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Lockstep.Core.Components.Game.IdReferenceComponent idReference { get { return (Lockstep.Core.Components.Game.IdReferenceComponent)GetComponent(GameComponentsLookup.IdReference); } }
    public bool hasIdReference { get { return HasComponent(GameComponentsLookup.IdReference); } }

    public void AddIdReference(uint newInternalId, uint newReferenceId) {
        var index = GameComponentsLookup.IdReference;
        var component = (Lockstep.Core.Components.Game.IdReferenceComponent)CreateComponent(index, typeof(Lockstep.Core.Components.Game.IdReferenceComponent));
        component.internalId = newInternalId;
        component.referenceId = newReferenceId;
        AddComponent(index, component);
    }

    public void ReplaceIdReference(uint newInternalId, uint newReferenceId) {
        var index = GameComponentsLookup.IdReference;
        var component = (Lockstep.Core.Components.Game.IdReferenceComponent)CreateComponent(index, typeof(Lockstep.Core.Components.Game.IdReferenceComponent));
        component.internalId = newInternalId;
        component.referenceId = newReferenceId;
        ReplaceComponent(index, component);
    }

    public void RemoveIdReference() {
        RemoveComponent(GameComponentsLookup.IdReference);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherIdReference;

    public static Entitas.IMatcher<GameEntity> IdReference {
        get {
            if (_matcherIdReference == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.IdReference);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIdReference = matcher;
            }

            return _matcherIdReference;
        }
    }
}
