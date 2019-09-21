﻿using System.Runtime.InteropServices;
using fluid_midi_event_t_ptr = System.IntPtr;
using fluid_midi_router_t_ptr = System.IntPtr;
using fluid_player_t_ptr = System.IntPtr;
using fluid_settings_t_ptr = System.IntPtr;
using fluid_midi_router_rule_t_ptr = System.IntPtr;
using fluid_midi_driver_t_ptr = System.IntPtr;
using fluid_synth_t_ptr = System.IntPtr;

namespace NFluidsynth.Native
{
    internal static unsafe partial class LibFluidsynth
    {
        internal delegate int handle_midi_event_func_t(byte[] data, fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern fluid_midi_event_t_ptr new_fluid_midi_event();

        [DllImport(LibraryName)]
        internal static extern int delete_fluid_midi_event(fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_set_type(fluid_midi_event_t_ptr evt,
            int type);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_get_type(fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_set_channel(fluid_midi_event_t_ptr evt,
            int chan);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_get_channel(fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_get_key(fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_set_key(fluid_midi_event_t_ptr evt,
            int key);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_get_velocity(fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_set_velocity(fluid_midi_event_t_ptr evt,
            int vel);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_get_control(fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_set_control(fluid_midi_event_t_ptr evt,
            int ctrl);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_get_value(fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_set_value(fluid_midi_event_t_ptr evt,
            int val);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_get_program(fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_set_program(fluid_midi_event_t_ptr evt,
            int val);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_get_pitch(fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_set_pitch(fluid_midi_event_t_ptr evt,
            int val);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_event_set_sysex(fluid_midi_event_t_ptr evt, byte[] data,
            int size, bool isDynamic);

        [DllImport(LibraryName)]
        internal static extern fluid_midi_router_t_ptr new_fluid_midi_router(fluid_settings_t_ptr settings,
            handle_midi_event_func_t handler, byte[] event_handler_data);

        [DllImport(LibraryName)]
        internal static extern int delete_fluid_midi_router(fluid_midi_router_t_ptr handler);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_router_set_default_rules(fluid_midi_router_t_ptr router);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_router_clear_rules(fluid_midi_router_t_ptr router);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_router_add_rule(fluid_midi_router_t_ptr router,
            fluid_midi_router_rule_t_ptr rule, FluidMidiRouterRuleType type);

        [DllImport(LibraryName)]
        internal static extern fluid_midi_router_rule_t_ptr new_fluid_midi_router_rule();

        [DllImport(LibraryName)]
        internal static extern void delete_fluid_midi_router_rule(fluid_midi_router_rule_t_ptr rule);

        [DllImport(LibraryName)]
        internal static extern void fluid_midi_router_rule_set_chan(fluid_midi_router_rule_t_ptr rule,
            int min, int max, float mul,
            int add);

        [DllImport(LibraryName)]
        internal static extern void fluid_midi_router_rule_set_param1(fluid_midi_router_rule_t_ptr rule,
            int min, int max, float mul,
            int add);

        [DllImport(LibraryName)]
        internal static extern void fluid_midi_router_rule_set_param2(fluid_midi_router_rule_t_ptr rule,
            int min, int max, float mul,
            int add);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_router_handle_midi_event(void* data, fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_dump_prerouter(void* data, fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern int fluid_midi_dump_postrouter(void* data, fluid_midi_event_t_ptr evt);

        [DllImport(LibraryName)]
        internal static extern fluid_midi_driver_t_ptr new_fluid_midi_driver(fluid_settings_t_ptr settings,
            handle_midi_event_func_t handler, void* event_handler_data);

        [DllImport(LibraryName)]
        internal static extern void delete_fluid_midi_driver(fluid_midi_driver_t_ptr driver);

        [DllImport(LibraryName)]
        internal static extern fluid_player_t_ptr new_fluid_player(fluid_synth_t_ptr synth);

        [DllImport(LibraryName)]
        internal static extern int delete_fluid_player(fluid_player_t_ptr player);

        [DllImport(LibraryName)]
        internal static extern int fluid_player_add(fluid_player_t_ptr player, string midifile);

        [DllImport(LibraryName)]
        internal static extern int fluid_player_play(fluid_player_t_ptr player);

        [DllImport(LibraryName)]
        internal static extern int fluid_player_stop(fluid_player_t_ptr player);

        [DllImport(LibraryName)]
        internal static extern int fluid_player_join(fluid_player_t_ptr player);

        [DllImport(LibraryName)]
        internal static extern int fluid_player_set_loop(fluid_player_t_ptr player,
            int loop);

        [DllImport(LibraryName)]
        internal static extern int fluid_player_set_midi_tempo(fluid_player_t_ptr player,
            int tempo);

        [DllImport(LibraryName)]
        internal static extern int fluid_player_set_bpm(fluid_player_t_ptr player,
            int bpm);

        [DllImport(LibraryName)]
        internal static extern FluidPlayerStatus fluid_player_get_status(fluid_player_t_ptr player);
    }
}
