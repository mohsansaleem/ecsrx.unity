﻿using EcsRx.Collections;
using EcsRx.Entities;
using EcsRx.Events;
using EcsRx.Unity.Dependencies;
using EcsRx.Unity.Systems;
using UnityEngine;
using Zenject;

namespace EcsRx.Examples.AutoRegisterSystems.Systems
{
    public class DefaultViewResolver : PrefabViewResolverSystem
    {
        public DefaultViewResolver(IEntityCollectionManager collectionManager, IEventSystem eventSystem, IUnityInstantiator instantiator) 
            : base(collectionManager, eventSystem, instantiator)
        {}

        protected override GameObject PrefabTemplate => GameObject.CreatePrimitive(PrimitiveType.Cube);

        protected override void OnViewCreated(IEntity entity, GameObject view)
        {
            view.name = $"entity-{entity.Id}";
        }
    }
}