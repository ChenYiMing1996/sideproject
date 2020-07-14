const path = require('path');
const VueLoaderPlugin = require('vue-loader/lib/plugin');
const webpack = require('webpack');
module.exports = {
    entry: './index.js',
    output: {
        filename: 'index.bundle.js',
        path: path.resolve(__dirname, './'),
    },
     mode: 'development',
  module: {
    rules: [
      {
        test: /\.vue$/,
        loader: 'vue-loader'
      },
      // this will apply to both plain `.js` files
      // AND `<script>` blocks in `.vue` files
      {
        test: /\.js$/,
        loader: 'babel-loader'
      },
      {
        test: /\.css$/,
        use: [
          'css-loader',
          'style-loader'
        ]
      },
      {
        test: /\.(png|jpg|svg|gif|svg|eot|ttf|woff|woff2|otf)\??$/,
        use: [
            {
                loader: 'file-loader'
            }
        ]
      },
      { 
        test: /\.scss$/, 
        loader: 'style!css!sass?sourceMap'
      }
    ]
  },
  plugins: [
    // make sure to include the plugin for the magic
    new VueLoaderPlugin(),
    new webpack.ProvidePlugin({
      $: "jquery",
      jQuery: "jquery"
    })
  ]
};