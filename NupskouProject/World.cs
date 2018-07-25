using System;
using System.Collections.Generic;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Rashka;


namespace NupskouProject {

    public class World {

        public static Box Box         => new Box (0,  0,  600, 750);
        public static Box PlayerBox   => new Box (20, 20, 580, 730);
        public static XY  BossPlace   => new XY (300, 250);
        public static XY  PlayerPlace => new XY (300, 500);

        public bool Paused;
        public int  Time = -1;

        private List <Entity> _entities = new List <Entity> ();
//        private EntityList _entities = new EntityList();


        public void Spawn (Entity entity) {
            _entities.Add (entity);
            entity.T0 = Time;
            entity.OnSpawn ();
        }


        public void Update () {
            if (Paused) return;

            Time++;

            OnUpdate ();

            for (int i = 0; i < _entities.Count; i++) {
                var entity = _entities[i];
                if (entity.Despawned) continue;
                entity.Update (Time - entity.T0);
            }
            _entities.RemoveAll (e => e.Despawned);
//            foreach (var entity in _entities) {
//                entity.Update ();
//            }
//            _entities.ClearDespawned ();

            Console.WriteLine (_entities.Count);
        }


        protected virtual void OnUpdate () {
            if (Time == 0) {
                Spawn (The.Player = new Player (PlayerPlace));
                Spawn (new Raden.Stages.Stage1 ());
            }
//            if (Time == 120) {
//                Spawn (new ShootTheLalkaSpawner (BossPlace));
//            }
        }


        public void Render () {
            for (int i = 0; i < _entities.Count; i++) {
                _entities[i].Render ();
            }
//            foreach (var entity in _entities) {
//                entity.Render ();
//            }
        }

    }

}