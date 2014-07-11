//// TODO -- FIXED NTILED SYSTEM, NOT CREATING TILES (Hold for 2d map version)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//using NTiled;

namespace Engine.Classes
{
    public class Mapper
    {
        //private static TiledReader tileReader;

        public static void GenerateMap()
        {
            var map = ReadMap("Resources/untitled.tmx");

            //

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MAP INFORMATION");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Version: {0}", map.Version);
            Console.WriteLine("Map Size: {0}x{1}", map.Width, map.Height);
            Console.WriteLine("Tile size: {0}x{1}", map.TileWidth, map.TileHeight);
            Console.WriteLine("Layers: {0}", map.Layers.Count);
            Console.WriteLine("Tilesets: {0}", map.Tilesets.Count);

            foreach (var layer in map.Layers)
            {
                Console.WriteLine();
                Console.WriteLine("{0}: {1}", layer.GetType().Name, layer.Name);
                Console.WriteLine(" Visible: {0}", layer.Visible);
                Console.WriteLine(" Opacity: {0}", layer.Opacity);
                Console.WriteLine(" Properties: {0}", layer.Properties.Count);

                //

                var tileLayer = layer as TiledTileLayer;

                Console.WriteLine(tileLayer.Tiles);

                if (tileLayer != null)
                {

                    ShowTileLayerInfo(tileLayer, map);
                }
                else
                {
                    var objectlayer = layer as TiledObjectGroup;
                    if (objectlayer != null)
                    {

                    }
                }
            }
        }

        private static TiledMap ReadMap(string mapPath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(mapPath))
                {
                    var document = XDocument.Load(mapPath);
                    var reader = new TiledReader();
                    return reader.Read(document);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        private static void ShowTileLayerInfo(TiledTileLayer tileLayer, TiledMap map)
        {
            // why is this empty?
            var tilesets = new HashSet<TiledTileset>();
            try
            {
                foreach (var tileIndex in tileLayer.Tiles)
                {
                    tilesets.Add(GetTilesetForTile(map, tileIndex));
                }

                if (tilesets.Count > 0)
                {
                    Console.WriteLine(" Using {0} tilesets", tilesets.Count);
                    foreach (var tileset in tilesets)
                    {
                        Console.WriteLine("  -> \"{0}\" ({1})", tileset.Name, tileset.Image.Source);
                    }
                }
            }
            catch (Exception e) { }
        }

        private static TiledTileset GetTilesetForTile(TiledMap map, int tileIndex)
        {
            // Get the tileset the tile belongs to.
            var tiledTileset = map.Tilesets.Where(t => t.FirstId <= tileIndex).OrderByDescending(t => t.FirstId).FirstOrDefault();
            if (tiledTileset == null)
            {
                // Try to search the other way around. This should solve it...
                tiledTileset = map.Tilesets.Where(t => t.FirstId >= tileIndex).OrderByDescending(t => t.FirstId).FirstOrDefault();
                if (tiledTileset == null)
                {
                    // Still couldn't find the tileset.
                    string message = string.Format("Could not find tileset for tile #{0}.", tileIndex);
                    throw new InvalidOperationException(message);
                }
            }
            return tiledTileset;
        }

        private static void ShowObjectLayerInfo(TiledObjectGroup objectlayer)
        {
            Console.WriteLine(" Color: {0}", objectlayer.Color.ToString());

            if (objectlayer.Objects.Count > 0)
            {
                Console.WriteLine(" Has {0} objects", objectlayer.Objects.Count);
                foreach (var obj in objectlayer.Objects)
                {
                    Console.WriteLine("  -> {0} ({1})", obj.Type, obj.GetType().Name);
                }
            }
        }
    }
}
