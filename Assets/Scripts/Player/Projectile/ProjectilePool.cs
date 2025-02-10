using UnityEngine;
using System.Collections.Generic;
using ServiceLocator.Utilities;

namespace ServiceLocator.Player.Projectile
{
    public class ProjectilePool : GenericObjectPool<ProjectileController>
    {
        private PlayerService playerService;
        private ProjectileView projectilePrefab;
        private List<ProjectileScriptableObject> projectileScriptableObjects;
        private Transform projectileContainer;

        public ProjectilePool(PlayerService playerService, ProjectileView projectilePrefab, List<ProjectileScriptableObject> projectileScriptableObjects)
        {
            this.playerService = playerService;
            this.projectilePrefab = projectilePrefab;
            this.projectileScriptableObjects = projectileScriptableObjects;
            this.projectileContainer = new GameObject("Projectile Container").transform;
        }

        public ProjectileController GetProjectile(ProjectileType projectileType)
        {
            ProjectileController projectile = GetItem();
            ProjectileScriptableObject scriptableObjectToUse = projectileScriptableObjects.Find(so => so.Type == projectileType);
            projectile.Init(scriptableObjectToUse);
            return projectile;
        }

        protected override ProjectileController CreateItem() => new ProjectileController(playerService, projectilePrefab, projectileContainer);
    }
}