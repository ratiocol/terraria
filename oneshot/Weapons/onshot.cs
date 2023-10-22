using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader; //테라리아 모드관련 설정들 사용
using Microsoft.Xna.Framework; //Microsoft사의 Xna Framework사용

namespace oneShot.Weapons //oneshot 폴더 안에 있는 Weapon폴더 안에 있는 파일이란 것을 알려줌
{
    public class onShot : ModItem //onshot을 모드 아이템으로 정의
    {
        public override void SetDefaults() //기본 설정
        {
            Item.width = 62; //가로 크기
            Item.height = 32; //세로 크기
            Item.scale = 0.75f; 
            Item.rare = ItemRarityID.Purple; //아이템의 희귀도 결정 cf)희귀도 순서 : Gray -> White -> Blue -> Green -> Orange -> ...

            // Use Properties
            Item.useTime = 8; // The item's use time in ticks (60 ticks == 1 second.)
            Item.useAnimation = 8; // The length of the item's use animation in ticks (60 ticks == 1 second.)
            Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, etc.)
            Item.autoReuse = true; // Whether or not you can hold click to automatically use it again.

            Item.UseSound = SoundID.Item176; //아이템 사용(총알 발사시) 소리를 Item176(파일이름)소리로 설정

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 999990; //아이템의 데미지
            Item.knockBack = 6f;
            Item.noMelee = true;


            Item.shoot = ProjectileID.PurificationPowder; // For some reason, all the guns in the vanilla source have this. (모든 총들은 이게 필요하다고 합니다..)
            Item.shootSpeed = 16f;
            Item.useAmmo = AmmoID.Bullet; //총알을 사용
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1); //흙 블록 1개를
            recipe.AddTile(TileID.WorkBenches); //작업대에서 사용하여 제작하도록 설정
            recipe.Register();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2f, -2f);
        }
