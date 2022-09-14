const { Telegraf } = require('telegraf');
require("dotenv").config()
const text = require('./const')

const bot = new Telegraf(process.env.bot_token);
bot.start((ctx) => ctx.reply('привет ${ ctx.message.from.first_name }!'))
bot.help((ctx) => ctx.reply(text.commands));

bot.launch();

// Enable graceful stop
process.once('SIGINT', () => bot.stop('SIGINT'));
process.once('SIGTERM', () => bot.stop('SIGTERM'));