using System;
using System.Windows.Forms;
using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;
using Dota2GSI;
using Dota2GSI.Nodes;

namespace Dota_2_Razer
{
    public class Dota2Chroma
    {
        public bool ManaBars { get; set; }
        public bool HpBars { get; set; }


        private IChroma _chroma;
        private GameStateListener _gameStateListener;
        private IKeyboard _keyboard;
        private Color _abilityColor         = new Color(0xFF00FFBB);
        private Color _abilityCooldownColor = new Color(0xFFFF0000);
        private Color _abilitySilencedColor = new Color(0xFFFF00FF);

        private static readonly Key[] HealthBarKeys =
        {
            Key.F1, Key.F2, Key.F3, Key.F4, Key.F5, Key.F6, Key.F7, Key.F8,
            Key.F9, Key.F10, Key.F11, Key.F12
        };

        private static readonly Key[] ManaBarKeys =
        {
            Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7, Key.D8,
            Key.D9, Key.D0, Key.OemMinus, Key.OemEquals
        };

        public static Key[] AbilityKeys = { Key.Q, Key.W, Key.E, Key.R, Key.T, Key.F };
        

        public void Start()
        {
            InitializeChromaSDK();
            InitializeDotaGSI();
            ManaBars = true;
            HpBars = true;
        }

        public void SetAbilityKey(KeyPressEventArgs e, int ability)
        {
            clearKey(AbilityKeys[ability]);
            Key abilityKey;
            Enum.TryParse(e.KeyChar.ToString().ToUpper(), out abilityKey);
            AbilityKeys[ability] = abilityKey;

        }

        private void clearKey(Key abilityKey)
        {
            _keyboard.SetKey(abilityKey, Color.Black);
        }

        private void InitializeChromaSDK()
        {
            _chroma = Chroma.Instance;
            _chroma.Initialize();

            _keyboard = _chroma.Keyboard;
            _keyboard.Clear();
        }

        private void InitializeDotaGSI()
        {
            _gameStateListener = new GameStateListener(4000);
            _gameStateListener.NewGameState += OnNewGameState;

            if (!_gameStateListener.Start())
            {
                MessageBox.Show(
                    "GameStateListener could not start. Try running this program as Administrator.\r\nExiting.");
                Environment.Exit(0);
            }
        }

        private void OnNewGameState(GameState gamestate)
        {
            if (gamestate.Map.GameState == DOTA_GameState.DOTA_GAMERULES_STATE_GAME_IN_PROGRESS || gamestate.Map.GameState == DOTA_GameState.DOTA_GAMERULES_STATE_PRE_GAME)
            {
                UpdateKeyboard(gamestate);


            }
        }

        private void UpdateKeyboard(GameState gamestate)
        {
            if (HpBars) UpdateHpBars(gamestate.Hero.HealthPercent);
            if (ManaBars) updateManaBars(gamestate.Hero.ManaPercent);
            UpdateAbilityKeys(gamestate);
        }

        private void UpdateAbilityKeys(GameState gs)
        {
            Abilities abilities = gs.Abilities;
            Color currentcolor;
            for (int i = 0; i < abilities.Count; i++)
            {
                currentcolor = _abilityColor;
                if (abilities[i].Cooldown > 0)
                {
                    currentcolor = _abilityCooldownColor;
                }
                if (gs.Hero.IsHexed || gs.Hero.IsSilenced || gs.Hero.IsStunned)
                {
                    currentcolor = _abilitySilencedColor;
                }

                _keyboard.SetKey(AbilityKeys[i], currentcolor);

            }

        }

        private void updateManaBars(int manaPercent)
        {
            int manaBarKeys = ManaBarKeys.GetLength(0);
            float percentOfMana = (float)(manaPercent / 100.0);
            int keysToLight = (int)Math.Floor(manaBarKeys * percentOfMana);


            if (_chroma.Initialized)
            {
                Color hpColor = new Color(0.0, 1.0 - percentOfMana, 1.0);
                for (int i = manaBarKeys - 1; i >= keysToLight; i--)
                {
                    _chroma.Keyboard.SetKey(ManaBarKeys[i], Color.White);
                }
                for (int i = 0; i < keysToLight; i++)
                {
                    _chroma.Keyboard.SetKey(ManaBarKeys[i], hpColor);
                }
            }
        }

        private void UpdateHpBars(int healthPercent)
        {
            int healthBarKeys = HealthBarKeys.GetLength(0);
            float percentOfHealth = (float)(healthPercent / 100.0);
            int keysToLight = (int)Math.Floor(healthBarKeys * percentOfHealth);


            if (_chroma.Initialized)
            {
                Color hpColor = new Color(1.0 - percentOfHealth, 1.0, 0.0);
                for (int i = healthBarKeys - 1; i >= keysToLight; i--)
                {
                    _chroma.Keyboard.SetKey(HealthBarKeys[i], Color.Red);
                }
                for (int i = 0; i < keysToLight; i++)
                {
                    _chroma.Keyboard.SetKey(HealthBarKeys[i], hpColor);
                }
            }
        }

        public void SetAbilityColor(string text)
        {
            try
            {
                _abilityColor = new Color(Convert.ToUInt32(text, 16));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure you're using valid hex. E.G. 00FF00");
            }
        }
        public void SetAbilityCooldownColor(string text)
        {
            try
            {
                _abilityCooldownColor = new Color(Convert.ToUInt32(text, 16));
            }
        
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure you're using valid hex. E.G. 00FF00");
            }
        }

        public void SetAbilitySilencedColor(string s)
        {
            try
            {
                _abilitySilencedColor = new Color(Convert.ToUInt32(s, 16));
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please make sure you're using valid hex. E.G. 00FF00");
            }
        }
    }
}