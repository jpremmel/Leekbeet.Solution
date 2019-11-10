var path = require('path');
var webpack = require('webpack');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const merge = require('webpack-merge');
const productionConfig = merge([
  {
    output: {
      publicPath: '/Leekbeet.Solution/'
    },
  }
]);

module.exports = function (env) {
  env = env || {};
  var isProd = env.NODE_ENV === 'production';

  // Setup base config for all environments
  var config = {
    entry: {
      main: './Client/js/main'
    },
    output: {
      path: path.join(__dirname, 'build'),
      filename: '[name].js',
    },
    devtool: 'eval-source-map',
    resolve: {
      extensions: ['.ts', '.tsx', '.js', '.jsx']
    },
    plugins: [
      new HtmlWebpackPlugin({
        title: 'Leekbeet',
        template: './Views/Shared/_Layout_Template.cshtml',
        inject: 'body'
      }),
      new webpack.ProvidePlugin({ $: 'jquery', jQuery: 'jquery' })
    ],
    module: {
      rules: [
        { test: /\.css?$/, use: ['style-loader', 'css-loader'] },
        { test: /\.(png|jpg|jpeg|gif|svg)$/, use: 'url-loader?limit=25000' },
        { test: /\.(png|woff|woff2|eot|ttf|svg)(\?|$)/, use: 'url-loader?limit=100000' }
      ]
    }
  }

  // Alter config for prod environment
  if (isProd) {
    config.devtool = 'source-map';
    config.plugins = config.plugins.concat([
      new webpack.optimize.UglifyJsPlugin({
        sourceMap: true
      })
    ]);
  }

  return config;
};